using Azure.Storage.Blobs;
using eFoodDelivery_API.DbContexts;
using eFoodDelivery_API.Models;
using eFoodDelivery_API.Services.Implementations;
using eFoodDelivery_API.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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

// activate Azure.Storage.Blobs nuget package
builder.Services.AddSingleton(blobService => // Singleton means there will only be one object when the application starts
    new BlobServiceClient(
        builder.Configuration.GetConnectionString("AzureImagesStorage")        
    )
);
builder.Services.AddSingleton<IBlobService, BlobService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
