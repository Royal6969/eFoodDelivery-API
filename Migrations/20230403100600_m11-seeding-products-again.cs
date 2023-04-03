using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m11seedingproductsagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                columns: new[] { "Id", "Category", "Description", "Image", "Md_date", "Md_uuid", "Name", "Price", "Tag" },
                values: new object[,]
                {
                    { 1, "Almuerzo", "Receta de cocina con base de arroz, con origen en la actual Comunidad Valenciana, hoy en día muy popular en toda España y servida en restaurantes de todo el mundo.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/1.paella-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(887), new Guid("9c444643-e4e2-437d-8c03-8957477ec2c7"), "Paella Valenciana", 9.9499999999999993, "Mejor valorados" },
                    { 2, "Almuerzo", "Tortilla u omelet ​ a la que se le agrega patatas troceadas.​ Se trata de uno de los platos más conocidos y emblemáticos de la cocina española.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/2.tortilla-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(896), new Guid("57ba30a1-7c31-403d-9b50-ec5f3fd568a3"), "Tortilla de Patatas", 7.9900000000000002, "Más vendidos" },
                    { 3, "Almuerzo", "​El salmorejo cordobés es una crema servida habitualmente como primer plato. Se elabora mediante una cierta cantidad de miga de pan,​ a la que se le incluye además ajo, aceite de oliva, sal y tomates.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/3.salmorejo-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(915), new Guid("204352ef-1ea9-4587-b886-aa48eb9c9f85"), "Salmorejo Cordobés", 6.4900000000000002, "Recomendados" },
                    { 4, "Almuerzo", "​Conjunto de hortalizas cocidas con unos aditamentos de carne, pescado y ave condimentada con una salsa mayonesa\", donde la remolacha, las judías verdes y las alcaparras forman parte de la receta.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/4.ensaladilla-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(922), new Guid("ad47ad4a-25e3-41ec-b357-a282263abc2c"), "Ensaladilla Rusa", 5.9500000000000002, "Más vendidos" },
                    { 5, "Almuerzo", "​Preparación culinaria de España y Portugal habitual de la gente que se dedica a la trashumancia española. Se elabora principalmente con pedazos de la miga de pan tostado acompañados de carnes y verduras.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/5.migas-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(928), new Guid("cec1979f-9bd5-4276-a2d3-4112b537505e"), "Migas Manchegas", 10.99, "Recomendados" },
                    { 6, "Cena", "​Se sirven generalmente como una tapa en muchos bares, o como raciones. Como algunos otros platos de marisco se suelen servir junto con una rodaja de limón.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/6.calamares-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(935), new Guid("133e5d07-81fe-43e8-aa28-49c9ba82f3e4"), "Calamares a la Romana", 8.75, "Mejor valorados" },
                    { 7, "Cena", "​Se trata de un plato festivo elaborado con pulpo cocido entero (generalmente en ollas de cobre) que está presente en las fiestas, ferias y romerías de Galicia.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/7.pulpo-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(945), new Guid("213d1d40-7b95-4013-aa87-59f12e1b6caa"), "Pulpo a la Gallega", 8.5, "Recomendados" },
                    { 8, "Almuerzo", "Guiso cuyo ingrediente principal son los garbanzos y los secundarios, aunque con gran protagonismo, diversas verduras, carnes y tocino de cerdo con algún embutido.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/8.cocido-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(953), new Guid("d60a84fb-c606-4a60-9afd-be51c7974c61"), "Cocido Madrileño", 9.9499999999999993, "Recomendados" },
                    { 9, "Cena", "​Porción de masa hecha de una salsa densa como la bechamel y un picadillo de diversos ingredientes, que ha sido rebozada en huevo y pan rallado, y frita en abundante aceite.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/9.croquetas-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(959), new Guid("b8037ce9-6b6b-476c-8dd7-1ce0d49da235"), "Croquetas", 7.9900000000000002, "Más vendidos" },
                    { 10, "Postre", "​Plato hecho de una rebanada de pan (habitualmente de varios días) que es empapada en leche, almíbar o vino y, tras ser rebozada en huevo, se fríe en una sartén con aceite.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/10.torrijas-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(965), new Guid("e9e7a998-29d0-42ba-881c-9935392168e6"), "Torrijas", 6.4500000000000002, "Mejor valorados" },
                    { 11, "Postre", "​Tipo de fruta de sartén que se suele servir como dulce navideño o de Semana Santa, típico de Andalucía y otras zonas de España, elaborado con masa de harina, frito en aceite de oliva y pasado por miel.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/11.pestiños-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(974), new Guid("05bd4eeb-8d71-409b-8502-a000627eb6cf"), "Pestiños", 5.75, "Recomendados" },
                    { 12, "Desayuno", "​Es una fruta de sartén hecha de agua, harina (de trigo generalmente, aunque puede ser de otro origen), aceite y sal. Pueden tener formas de bastón, en lazos o rulos (espirales).", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/12.churros-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(980), new Guid("10942c83-1f9f-4ff4-b367-2d39b9af11e5"), "Churros", 3.9900000000000002, "Más vendidos" },
                    { 13, "Postre", "​Tipo de fritura de sartén dulce propia de la repostería española realizado a base de harina cocida con leche y azúcar hasta que este preparado espesa, cortándose la masa resultante en porciones que posteriormente se fríen.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/13.leche-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(986), new Guid("e64efde9-74ca-4f32-ac21-b95aa7568e5b"), "Leche Frita", 4.75, "Recomendados" },
                    { 14, "Postre", "Son una receta dulce propia de Extremadura que se preparan desde Todos los Santos, pasando por Carnaval hasta Semana Santa. Se trata de una receta muy antigua que nos recuerda a las rosquillas por el tipo de masa.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/14.huesillos-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(993), new Guid("c6133384-8657-436e-8e8b-2f4e6868fded"), "Huesillos Extremeños", 3.5, "Recomendados" },
                    { 15, "Bebidas", "​Lata de CocaCola de 33cl. CocaCola Zero (sin azúcar) o CocaCola Original", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/15.cocacola-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1001), new Guid("912d423b-8ca0-40e9-a3e6-ceb7e25b2bcb"), "CocaCola", 1.5, "Más vendidos" },
                    { 16, "Bebidas", "Lata de Fanta de 33cl. Fanta de naranja o Fanta de limón​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/16.fanta-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1008), new Guid("0bc62100-9088-4fe4-9aba-81b42142b0bc"), "Fanta", 1.5, "Recomendados" },
                    { 17, "Bebidas", "Lata de 7up de 33cl. 7up free (sin azúcar) o 7up original​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/17.7up-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1014), new Guid("2e6690a6-6c1e-48d4-9738-257a3a13ee98"), "7up", 1.5, "Recomendados" },
                    { 18, "Bebidas", "​Lata de Cruzcampo de 33cl. Cerveza Pilsen", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/18.cruzcampo-pilsen-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1021), new Guid("cfa99996-56f8-405b-9132-1af4fd9205a1"), "Cruzcampo Pilsen", 1.8, "Más vendidos" },
                    { 19, "Bebidas", "​Lata de Cruzcampo de 33cl. Cerveza Especial", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/19.cruzcampo-especial-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1030), new Guid("ecbff882-013b-482b-a396-241170acf6fb"), "Cruzcampo Especial", 1.8999999999999999, "Mejor valorados" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
