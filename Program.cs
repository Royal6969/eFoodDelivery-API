using Azure.Storage.Blobs;
using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Services.Implementations;
using eFoodDelivery_API.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

/************************************************************************************************************/
/******************************************** Builder Services Starts ***************************************/
/************************************************************************************************************/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add connection strings for DbContexts
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection"));
});

// Add Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

// to turn off the default configuration for Identity in Register // only for development
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 1;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
});

// how to decode the JWT?? We'll use the key we are storing inside the appsettings.json
var JWTsecretKey = builder.Configuration.GetValue<string>("ApiSecrets:JWTsecret"); // retrieve the key like we did in Login() method
// once we have that key inside the JWT bearer, we have to write the token validation parameters
TokenValidationParameters tokenValidationParameters = new TokenValidationParameters();
tokenValidationParameters.ValidateIssuerSigningKey = true;
tokenValidationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(JWTsecretKey));
// now I'm working locally but when I deploy the project, I'll have a certain audience like only this URL can send the token
tokenValidationParameters.ValidateIssuer = false;
tokenValidationParameters.ValidateAudience = false;

builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; // just a constant value of bearer
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme; // we'll also have the same default challenge scheme on that
    }
).AddJwtBearer(options => // we have to add the JWT bearer as well and we have to configure on what we allow with JWT bearer
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = tokenValidationParameters;
    }
);

builder.Services.AddCors(); // if an API is being called from some other URL, it will work

// activate Azure.Storage.Blobs nuget package
builder.Services.AddSingleton(blobService => // Singleton means there will only be one object when the application starts
    new BlobServiceClient(
        builder.Configuration.GetConnectionString("AzureImagesStorage")        
    )
);
builder.Services.AddSingleton<IBlobService, BlobService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//////////////////////////////////////////// Swagger Security /////////////////////////////////////////////
OpenApiSecurityScheme openApiSecurityScheme1 = new OpenApiSecurityScheme();
openApiSecurityScheme1.Description = // add some text here where we will say that enter better space and then your token in the input field
    "JWT Authorization header using the Bearer scheme. \r\n\r\n " +
    "Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\n" +
    "Example: \"Bearer 12345abcdef\"";
openApiSecurityScheme1.Name = "Authorization";
openApiSecurityScheme1.In = ParameterLocation.Header; // we have to define where we will add this and that will be inside 
openApiSecurityScheme1.Scheme = JwtBearerDefaults.AuthenticationScheme; // constant "Bearer"

OpenApiReference openApiReference = new OpenApiReference();
openApiReference.Type = ReferenceType.SecurityScheme;
openApiReference.Id = "Bearer";

OpenApiSecurityScheme openApiSecurityScheme2 = new OpenApiSecurityScheme();
openApiSecurityScheme2.Reference = openApiReference;
openApiSecurityScheme2.Scheme = "oauth2";
openApiSecurityScheme2.Name = "Bearer";
openApiSecurityScheme2.In = ParameterLocation.Header;

builder.Services.AddSwaggerGen(options => // here we can configure options on SwaggerGen and define that for the security definition we want to use bearer token.
{
    options.AddSecurityDefinition(
        JwtBearerDefaults.AuthenticationScheme, // --> constant "Bearer"
        openApiSecurityScheme1
    );

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            openApiSecurityScheme2,
            new List<string>()
        }
    });
});
///////////////////////////////////////////////////////////////////////////////////////////////////////////


/************************************************************************************************************/
/************************************************* App Pipeline Starts **************************************/
/************************************************************************************************************/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(options => // when we have to add cors, also inside the request pipeline, we have to use cors
{
    options
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()
    ;
});

app.UseAuthentication(); // adding authentication we can get its endpoint in swagger
app.UseAuthorization();  // it was here by default

app.MapControllers();

app.Run();
