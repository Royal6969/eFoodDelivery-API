﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eFoodDelivery_API.DbContexts;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230529160824_m-14-add-code-field")]
    partial class m14addcodefield
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dlk_efooddelivery_api")
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("dlk_roles", "dlk_efooddelivery_api");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("dlk_role_claim", "dlk_efooddelivery_api");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("dlk_user_claim", "dlk_efooddelivery_api");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("dlk_user_login", "dlk_efooddelivery_api");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("dlk_user_roles", "dlk_efooddelivery_api");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("dlk_user_tokens", "dlk_efooddelivery_api");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Md_date");

                    b.Property<Guid>("Md_uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Md_uuid");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.ToTable("dwh_cart", "dwh_efooddelivery_api");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("CartId");

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Md_date");

                    b.Property<Guid>("Md_uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Md_uuid");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductId");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("dwh_cartItem", "dwh_efooddelivery_api");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("ClientEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClientEmail");

                    b.Property<string>("ClientId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ClientId");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClientName");

                    b.Property<string>("ClientPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClientPhone");

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Md_date");

                    b.Property<Guid>("Md_uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Md_uuid");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("OrderDate");

                    b.Property<string>("OrderPaymentID")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OrderPaymentID");

                    b.Property<int>("OrderQuantityItems")
                        .HasColumnType("int")
                        .HasColumnName("OrderQuantityItems");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OrderStatus");

                    b.Property<double>("OrderTotal")
                        .HasColumnType("float")
                        .HasColumnName("OrderTotal");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientId");

                    b.ToTable("dwh_order", "dwh_efooddelivery_api");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderDetailsId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailsId"));

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Md_date");

                    b.Property<Guid>("Md_uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Md_uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderId");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("Price");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductId");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("dwh_orderDetails", "dwh_efooddelivery_api");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Category");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Description");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Image");

                    b.Property<DateTime>("Md_date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Md_date");

                    b.Property<Guid>("Md_uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Md_uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Name");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("Price");

                    b.Property<string>("Tag")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Tag");

                    b.HasKey("Id");

                    b.ToTable("dwh_product", "dwh_efooddelivery_api");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Almuerzo",
                            Description = "Receta de cocina con base de arroz, con origen en la actual Comunidad Valenciana, hoy en día muy popular en toda España y servida en restaurantes de todo el mundo.​",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/1.paella-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8903),
                            Md_uuid = new Guid("56d2f2b3-911d-4ef1-b629-654a1768a97b"),
                            Name = "Paella Valenciana",
                            Price = 9.9499999999999993,
                            Tag = "Mejor valorados"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Almuerzo",
                            Description = "Tortilla u omelet ​ a la que se le agrega patatas troceadas.​ Se trata de uno de los platos más conocidos y emblemáticos de la cocina española.​",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/2.tortilla-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8912),
                            Md_uuid = new Guid("8aafcb1e-15e3-40fa-b8de-68a2ac2a6c54"),
                            Name = "Tortilla de Patatas",
                            Price = 7.9900000000000002,
                            Tag = "Más vendidos"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Almuerzo",
                            Description = "​El salmorejo cordobés es una crema servida habitualmente como primer plato. Se elabora mediante una cierta cantidad de miga de pan,​ a la que se le incluye además ajo, aceite de oliva, sal y tomates.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/3.salmorejo-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8919),
                            Md_uuid = new Guid("f83ebbb8-7076-4a6b-aaf1-6231f3d1b78e"),
                            Name = "Salmorejo Cordobés",
                            Price = 6.4900000000000002,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Almuerzo",
                            Description = "​Conjunto de hortalizas cocidas con unos aditamentos de carne, pescado y ave condimentada con una salsa mayonesa\", donde la remolacha, las judías verdes y las alcaparras forman parte de la receta.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/4.ensaladilla-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8926),
                            Md_uuid = new Guid("7773d882-2f0b-4d3d-9a3e-45c084c0a98e"),
                            Name = "Ensaladilla Rusa",
                            Price = 5.9500000000000002,
                            Tag = "Más vendidos"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Almuerzo",
                            Description = "​Preparación culinaria de España y Portugal habitual de la gente que se dedica a la trashumancia española. Se elabora principalmente con pedazos de la miga de pan tostado acompañados de carnes y verduras.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/5.migas-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8936),
                            Md_uuid = new Guid("258118bc-5cbd-4b4c-a6cb-b869bf5f7c99"),
                            Name = "Migas Manchegas",
                            Price = 10.99,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Cena",
                            Description = "​Se sirven generalmente como una tapa en muchos bares, o como raciones. Como algunos otros platos de marisco se suelen servir junto con una rodaja de limón.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/6.calamares-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8943),
                            Md_uuid = new Guid("f969a0db-8005-466a-bb61-460bbd136d2b"),
                            Name = "Calamares a la Romana",
                            Price = 8.75,
                            Tag = "Mejor valorados"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Cena",
                            Description = "​Se trata de un plato festivo elaborado con pulpo cocido entero (generalmente en ollas de cobre) que está presente en las fiestas, ferias y romerías de Galicia.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/7.pulpo-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8950),
                            Md_uuid = new Guid("b018a082-10bc-499b-bbb1-906c91e26b6f"),
                            Name = "Pulpo a la Gallega",
                            Price = 8.5,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Almuerzo",
                            Description = "Guiso cuyo ingrediente principal son los garbanzos y los secundarios, aunque con gran protagonismo, diversas verduras, carnes y tocino de cerdo con algún embutido.​",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/8.cocido-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8956),
                            Md_uuid = new Guid("0fea3536-2398-4445-941e-23765af86cc8"),
                            Name = "Cocido Madrileño",
                            Price = 9.9499999999999993,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Cena",
                            Description = "​Porción de masa hecha de una salsa densa como la bechamel y un picadillo de diversos ingredientes, que ha sido rebozada en huevo y pan rallado, y frita en abundante aceite.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/9.croquetas-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8965),
                            Md_uuid = new Guid("865836fb-d74b-49f6-9ec4-0f2be2d3e6f2"),
                            Name = "Croquetas",
                            Price = 7.9900000000000002,
                            Tag = "Más vendidos"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Postre",
                            Description = "​Plato hecho de una rebanada de pan (habitualmente de varios días) que es empapada en leche, almíbar o vino y, tras ser rebozada en huevo, se fríe en una sartén con aceite.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/10.torrijas-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8972),
                            Md_uuid = new Guid("84940c74-2e3e-4fc7-bf43-cdf47fccd149"),
                            Name = "Torrijas",
                            Price = 6.4500000000000002,
                            Tag = "Mejor valorados"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Postre",
                            Description = "​Tipo de fruta de sartén que se suele servir como dulce navideño o de Semana Santa, típico de Andalucía y otras zonas de España, elaborado con masa de harina, frito en aceite de oliva y pasado por miel.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/11.pestiños-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8979),
                            Md_uuid = new Guid("40c9e9be-5667-4d24-a389-53d82a4777d8"),
                            Name = "Pestiños",
                            Price = 5.75,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Desayuno",
                            Description = "​Es una fruta de sartén hecha de agua, harina (de trigo generalmente, aunque puede ser de otro origen), aceite y sal. Pueden tener formas de bastón, en lazos o rulos (espirales).",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/12.churros-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8986),
                            Md_uuid = new Guid("e262d2ac-f8f0-4391-9480-e8dc0e78735c"),
                            Name = "Churros",
                            Price = 3.9900000000000002,
                            Tag = "Más vendidos"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Postre",
                            Description = "​Tipo de fritura de sartén dulce propia de la repostería española realizado a base de harina cocida con leche y azúcar hasta que este preparado espesa, cortándose la masa resultante en porciones que posteriormente se fríen.",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/13.leche-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8995),
                            Md_uuid = new Guid("c3962db5-1cff-4b9c-aee3-eab597e98a40"),
                            Name = "Leche Frita",
                            Price = 4.75,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Postre",
                            Description = "Son una receta dulce propia de Extremadura que se preparan desde Todos los Santos, pasando por Carnaval hasta Semana Santa. Se trata de una receta muy antigua que nos recuerda a las rosquillas por el tipo de masa.​",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/14.huesillos-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9002),
                            Md_uuid = new Guid("9d88f6bd-9f21-4fe8-abd1-aee19d646fe9"),
                            Name = "Huesillos Extremeños",
                            Price = 3.5,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Bebidas",
                            Description = "​Lata de CocaCola de 33cl. CocaCola Zero (sin azúcar) o CocaCola Original",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/15.cocacola-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9009),
                            Md_uuid = new Guid("5a0c7151-6f92-4fa5-b12e-ddcd9ce03f1e"),
                            Name = "CocaCola",
                            Price = 1.5,
                            Tag = "Más vendidos"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Bebidas",
                            Description = "Lata de Fanta de 33cl. Fanta de naranja o Fanta de limón​",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/16.fanta-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9016),
                            Md_uuid = new Guid("5ba2d014-bfde-445e-b03d-762820c9e3b1"),
                            Name = "Fanta",
                            Price = 1.5,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Bebidas",
                            Description = "Lata de 7up de 33cl. 7up free (sin azúcar) o 7up original​",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/17.7up-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9025),
                            Md_uuid = new Guid("1289ef02-8ac7-474b-8a08-96fc957db2a5"),
                            Name = "7up",
                            Price = 1.5,
                            Tag = "Recomendados"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Bebidas",
                            Description = "​Lata de Cruzcampo de 33cl. Cerveza Pilsen",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/18.cruzcampo-pilsen-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9031),
                            Md_uuid = new Guid("26e158e3-28ed-4007-87df-e3b46ee53256"),
                            Name = "Cruzcampo Pilsen",
                            Price = 1.8,
                            Tag = "Más vendidos"
                        },
                        new
                        {
                            Id = 19,
                            Category = "Bebidas",
                            Description = "​Lata de Cruzcampo de 33cl. Cerveza Especial",
                            Image = "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/19.cruzcampo-especial-nobg.png",
                            Md_date = new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9038),
                            Md_uuid = new Guid("946b01b6-b24b-4689-99c9-c4551f9991fb"),
                            Name = "Cruzcampo Especial",
                            Price = 1.8999999999999999,
                            Tag = "Mejor valorados"
                        });
                });

            modelBuilder.Entity("eFoodDelivery_API.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("dlk_users", "dlk_efooddelivery_api");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("eFoodDelivery_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("eFoodDelivery_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eFoodDelivery_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("eFoodDelivery_API.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.CartItem", b =>
                {
                    b.HasOne("eFoodDelivery_API.Entities.Cart", null)
                        .WithMany("CartItemsList")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eFoodDelivery_API.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.Order", b =>
                {
                    b.HasOne("eFoodDelivery_API.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.OrderDetails", b =>
                {
                    b.HasOne("eFoodDelivery_API.Entities.Order", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eFoodDelivery_API.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.Cart", b =>
                {
                    b.Navigation("CartItemsList");
                });

            modelBuilder.Entity("eFoodDelivery_API.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
