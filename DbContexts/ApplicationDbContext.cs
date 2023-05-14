using eFoodDelivery_API.Entities;
using eFoodDelivery_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eFoodDelivery_API.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // contructor needed for context
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        // navigation properties for entities (also it creates the tables)
        public DbSet<ApplicationUser> ApplicationUsersDbSet { get; set; }
        public DbSet<Product> ProductsDbSet { get; set; }
        public DbSet<Cart> CartDbSet { get; set; }
        public DbSet<CartItem> CartItemsDbSet { get; set; }
        public DbSet<Order> OrdersDbSet { get; set; }
        public DbSet<OrderDetails> OrderDetailsDbSet { get; set; }

        // overrriding the OnModelCreating() method for customize our entities (tables)
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserEntityConfiguration());  // apply IdentityUser changes
            builder.HasDefaultSchema("dlk_efooddelivery_api");          // default schema for Identity tables

            // changing names for Identity tables
            builder.Entity<ApplicationUser>().ToTable("dlk_users");
            builder.Entity<IdentityRole>().ToTable("dlk_roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("dlk_user_roles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("dlk_role_claim");
            builder.Entity<IdentityUserClaim<string>>().ToTable("dlk_user_claim");
            builder.Entity<IdentityUserLogin<string>>().ToTable("dlk_user_login");
            builder.Entity<IdentityUserToken<string>>().ToTable("dlk_user_tokens");
                
            builder.Entity<Product>().HasData(
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 1,
                    Name = "Paella Valenciana",
                    Description = "Receta de cocina con base de arroz, con origen en la actual Comunidad Valenciana, hoy en día muy popular en toda España y servida en restaurantes de todo el mundo.​",
                    Tag = "Mejor valorados",
                    Category = "Almuerzo",
                    Price = 9.95,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/1.paella-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 2,
                    Name = "Tortilla de Patatas",
                    Description = "Tortilla u omelet ​ a la que se le agrega patatas troceadas.​ Se trata de uno de los platos más conocidos y emblemáticos de la cocina española.​",
                    Tag = "Más vendidos",
                    Category = "Almuerzo",
                    Price = 7.99,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/2.tortilla-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 3,
                    Name = "Salmorejo Cordobés",
                    Description = "​El salmorejo cordobés es una crema servida habitualmente como primer plato. Se elabora mediante una cierta cantidad de miga de pan,​ a la que se le incluye además ajo, aceite de oliva, sal y tomates.",
                    Tag = "Recomendados",
                    Category = "Almuerzo",
                    Price = 6.49,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/3.salmorejo-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 4,
                    Name = "Ensaladilla Rusa",
                    Description = "​Conjunto de hortalizas cocidas con unos aditamentos de carne, pescado y ave condimentada con una salsa mayonesa\", donde la remolacha, las judías verdes y las alcaparras forman parte de la receta.",
                    Tag = "Más vendidos",
                    Category = "Almuerzo",
                    Price = 5.95,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/4.ensaladilla-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 5,
                    Name = "Migas Manchegas",
                    Description = "​Preparación culinaria de España y Portugal habitual de la gente que se dedica a la trashumancia española. Se elabora principalmente con pedazos de la miga de pan tostado acompañados de carnes y verduras.",
                    Tag = "Recomendados",
                    Category = "Almuerzo",
                    Price = 10.99,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/5.migas-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 6,
                    Name = "Calamares a la Romana",
                    Description = "​Se sirven generalmente como una tapa en muchos bares, o como raciones. Como algunos otros platos de marisco se suelen servir junto con una rodaja de limón.",
                    Tag = "Mejor valorados",
                    Category = "Cena",
                    Price = 8.75,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/6.calamares-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 7,
                    Name = "Pulpo a la Gallega",
                    Description = "​Se trata de un plato festivo elaborado con pulpo cocido entero (generalmente en ollas de cobre) que está presente en las fiestas, ferias y romerías de Galicia.",
                    Tag = "Recomendados",
                    Category = "Cena",
                    Price = 8.50,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/7.pulpo-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 8,
                    Name = "Cocido Madrileño",
                    Description = "Guiso cuyo ingrediente principal son los garbanzos y los secundarios, aunque con gran protagonismo, diversas verduras, carnes y tocino de cerdo con algún embutido.​",
                    Tag = "Recomendados",
                    Category = "Almuerzo",
                    Price = 9.95,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/8.cocido-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 9,
                    Name = "Croquetas",
                    Description = "​Porción de masa hecha de una salsa densa como la bechamel y un picadillo de diversos ingredientes, que ha sido rebozada en huevo y pan rallado, y frita en abundante aceite.",
                    Tag = "Más vendidos",
                    Category = "Cena",
                    Price = 7.99,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/9.croquetas-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 10,
                    Name = "Torrijas",
                    Description = "​Plato hecho de una rebanada de pan (habitualmente de varios días) que es empapada en leche, almíbar o vino y, tras ser rebozada en huevo, se fríe en una sartén con aceite.",
                    Tag = "Mejor valorados",
                    Category = "Postre",
                    Price = 6.45,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/10.torrijas-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 11,
                    Name = "Pestiños",
                    Description = "​Tipo de fruta de sartén que se suele servir como dulce navideño o de Semana Santa, típico de Andalucía y otras zonas de España, elaborado con masa de harina, frito en aceite de oliva y pasado por miel.",
                    Tag = "Recomendados",
                    Category = "Postre",
                    Price = 5.75,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/11.pestiños-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 12,
                    Name = "Churros",
                    Description = "​Es una fruta de sartén hecha de agua, harina (de trigo generalmente, aunque puede ser de otro origen), aceite y sal. Pueden tener formas de bastón, en lazos o rulos (espirales).",
                    Tag = "Más vendidos",
                    Category = "Desayuno",
                    Price = 3.99,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/12.churros-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 13,
                    Name = "Leche Frita",
                    Description = "​Tipo de fritura de sartén dulce propia de la repostería española realizado a base de harina cocida con leche y azúcar hasta que este preparado espesa, cortándose la masa resultante en porciones que posteriormente se fríen.",
                    Tag = "Recomendados",
                    Category = "Postre",
                    Price = 4.75,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/13.leche-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 14,
                    Name = "Huesillos Extremeños",
                    Description = "Son una receta dulce propia de Extremadura que se preparan desde Todos los Santos, pasando por Carnaval hasta Semana Santa. Se trata de una receta muy antigua que nos recuerda a las rosquillas por el tipo de masa.​",
                    Tag = "Recomendados",
                    Category = "Postre",
                    Price = 3.50,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/14.huesillos-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 15,
                    Name = "CocaCola",
                    Description = "​Lata de CocaCola de 33cl. CocaCola Zero (sin azúcar) o CocaCola Original",
                    Tag = "Más vendidos",
                    Category = "Bebidas",
                    Price = 1.50,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/15.cocacola-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 16,
                    Name = "Fanta",
                    Description = "Lata de Fanta de 33cl. Fanta de naranja o Fanta de limón​",
                    Tag = "Recomendados",
                    Category = "Bebidas",
                    Price = 1.50,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/16.fanta-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 17,
                    Name = "7up",
                    Description = "Lata de 7up de 33cl. 7up free (sin azúcar) o 7up original​",
                    Tag = "Recomendados",
                    Category = "Bebidas",
                    Price = 1.50,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/17.7up-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 18,
                    Name = "Cruzcampo Pilsen",
                    Description = "​Lata de Cruzcampo de 33cl. Cerveza Pilsen",
                    Tag = "Más vendidos",
                    Category = "Bebidas",
                    Price = 1.80,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/18.cruzcampo-pilsen-nobg.png"
                },
                new Product
                {
                    Md_uuid = Guid.NewGuid(),
                    Md_date = DateTime.Now,
                    Id = 19,
                    Name = "Cruzcampo Especial",
                    Description = "​Lata de Cruzcampo de 33cl. Cerveza Especial",
                    Tag = "Mejor valorados",
                    Category = "Bebidas",
                    Price = 1.90,
                    Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/19.cruzcampo-especial-nobg.png"
                }
            );
        
        }
    }
}
