using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m3sdproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                columns: new[] { "Id", "Category", "Description", "Image", "Md_date", "Md_uuid", "Name", "Price", "Tag" },
                values: new object[,]
                {
                    { 1, "Almuerzo", "Receta de cocina con base de arroz, con origen en la actual Comunidad Valenciana, hoy en día muy popular en toda España y servida en restaurantes de todo el mundo.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/1.paella-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8027), new Guid("a53cf779-73a4-470a-8d5e-2cdbc2ece0c9"), "Paella Valenciana", 9.9499999999999993, "Mejor valorados" },
                    { 2, "Almuerzo", "Tortilla u omelet ​ a la que se le agrega patatas troceadas.​ Se trata de uno de los platos más conocidos y emblemáticos de la cocina española.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/2.tortilla-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8038), new Guid("df8e8a16-9043-4f79-9481-08f443e12a48"), "Tortilla de Patatas", 7.9900000000000002, "Más vendidos" },
                    { 3, "Almuerzo", "​El salmorejo cordobés es una crema servida habitualmente como primer plato. Se elabora mediante una cierta cantidad de miga de pan,​ a la que se le incluye además ajo, aceite de oliva, sal y tomates.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/3.salmorejo-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8062), new Guid("7e095895-52d6-490b-aabe-eb8eaa58fe2d"), "Salmorejo Cordobés", 6.4900000000000002, "Recomendados" },
                    { 4, "Almuerzo", "​Conjunto de hortalizas cocidas con unos aditamentos de carne, pescado y ave condimentada con una salsa mayonesa\", donde la remolacha, las judías verdes y las alcaparras forman parte de la receta.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/4.ensaladilla-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8072), new Guid("5d059545-bceb-4fdf-85b0-733e4c656aa3"), "Ensaladilla Rusa", 5.9500000000000002, "Más vendidos" },
                    { 5, "Almuerzo", "​Preparación culinaria de España y Portugal habitual de la gente que se dedica a la trashumancia española. Se elabora principalmente con pedazos de la miga de pan tostado acompañados de carnes y verduras.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/5.migas-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8105), new Guid("66f5ba45-842c-4491-b229-fd6389e22472"), "Migas Manchegas", 10.99, "Recomendados" },
                    { 6, "Cena", "​Se sirven generalmente como una tapa en muchos bares, o como raciones. Como algunos otros platos de marisco se suelen servir junto con una rodaja de limón.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/6.calamares-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8115), new Guid("fb95596a-1aa5-42aa-94b1-14849a3f224b"), "Calamares a la Romana", 8.75, "Mejor valorados" },
                    { 7, "Cena", "​Se trata de un plato festivo elaborado con pulpo cocido entero (generalmente en ollas de cobre) que está presente en las fiestas, ferias y romerías de Galicia.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/7.pulpo-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8127), new Guid("bd719ccb-79ac-473d-b8fa-2d2e137a62f1"), "Pulpo a la Gallega", 8.5, "Recomendados" },
                    { 8, "Almuerzo", "Guiso cuyo ingrediente principal son los garbanzos y los secundarios, aunque con gran protagonismo, diversas verduras, carnes y tocino de cerdo con algún embutido.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/8.cocido-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8133), new Guid("4a781810-f311-482d-8fa6-1ee2b69b78ad"), "Cocido Madrileño", 9.9499999999999993, "Recomendados" },
                    { 9, "Cena", "​Porción de masa hecha de una salsa densa como la bechamel y un picadillo de diversos ingredientes, que ha sido rebozada en huevo y pan rallado, y frita en abundante aceite.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/9.croquetas-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8149), new Guid("57de4cf5-4be3-4c72-bd33-11f1fcd380e6"), "Croquetas", 7.9900000000000002, "Más vendidos" },
                    { 10, "Postre", "​Plato hecho de una rebanada de pan (habitualmente de varios días) que es empapada en leche, almíbar o vino y, tras ser rebozada en huevo, se fríe en una sartén con aceite.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/10.torrijas-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8155), new Guid("d381efce-780c-4a59-8b5e-58291f4343fb"), "Torrijas", 6.4500000000000002, "Mejor valorados" },
                    { 11, "Postre", "​Tipo de fruta de sartén que se suele servir como dulce navideño o de Semana Santa, típico de Andalucía y otras zonas de España, elaborado con masa de harina, frito en aceite de oliva y pasado por miel.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/11.pestiños-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8164), new Guid("8a6e3b3c-bab4-459e-ad0b-ec2373e0367f"), "Pestiños", 5.75, "Recomendados" },
                    { 12, "Desayuno", "​Es una fruta de sartén hecha de agua, harina (de trigo generalmente, aunque puede ser de otro origen), aceite y sal. Pueden tener formas de bastón, en lazos o rulos (espirales).", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/12.churros-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8170), new Guid("3e46e184-0ca7-4c34-8e2c-bd810173c22d"), "Churros", 3.9900000000000002, "Más vendidos" },
                    { 13, "Postre", "​Tipo de fritura de sartén dulce propia de la repostería española realizado a base de harina cocida con leche y azúcar hasta que este preparado espesa, cortándose la masa resultante en porciones que posteriormente se fríen.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/13.leche-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8177), new Guid("4f7fe882-5f1a-4684-a2c4-fa512cca72c0"), "Leche Frita", 4.75, "Recomendados" },
                    { 14, "Postre", "Son una receta dulce propia de Extremadura que se preparan desde Todos los Santos, pasando por Carnaval hasta Semana Santa. Se trata de una receta muy antigua que nos recuerda a las rosquillas por el tipo de masa.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/14.huesillos-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8184), new Guid("bdf7e8a1-3b59-45fc-9b3f-88b62893e7a3"), "Huesillos Extremeños", 3.5, "Recomendados" },
                    { 15, "Bebidas", "​Lata de CocaCola de 33cl. CocaCola Zero (sin azúcar) o CocaCola Original", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/15.cocacola-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8192), new Guid("ff1a6101-2265-4a7e-9d38-dd5c4873d4ba"), "CocaCola", 1.5, "Más vendidos" },
                    { 16, "Bebidas", "Lata de Fanta de 33cl. Fanta de naranja o Fanta de limón​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/16.fanta-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8199), new Guid("00096934-06c3-45e2-968b-a0bcecff5cc5"), "Fanta", 1.5, "Recomendados" },
                    { 17, "Bebidas", "Lata de 7up de 33cl. 7up free (sin azúcar) o 7up original​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/17.7up-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8205), new Guid("c6f8ef0f-fa2a-4f7e-8363-30e832e2636c"), "7up", 1.5, "Recomendados" },
                    { 18, "Bebidas", "​Lata de Cruzcampo de 33cl. Cerveza Pilsen", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/18.cruzcampo-pilsen-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8212), new Guid("176b150e-bb6f-466b-a69a-8a3b1096c85b"), "Cruzcampo Pilsen", 1.8, "Más vendidos" },
                    { 19, "Bebidas", "​Lata de Cruzcampo de 33cl. Cerveza Especial", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/19.cruzcampo-especial-nobg.png", new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8220), new Guid("92d4ded8-1a4a-44eb-ac82-31e9b1132883"), "Cruzcampo Especial", 1.8999999999999999, "Mejor valorados" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
