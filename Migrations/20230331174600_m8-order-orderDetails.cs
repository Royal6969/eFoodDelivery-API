using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m8orderorderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "dwh_order",
                schema: "dwh_efooddelivery_api",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Md_uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Md_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderPaymentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderQuantityItems = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dwh_order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_dwh_order_dlk_users_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dlk_efooddelivery_api",
                        principalTable: "dlk_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "dwh_order_details",
                schema: "dwh_efooddelivery_api",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Md_uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Md_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemQuantity = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemPrice = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dwh_order_details", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_dwh_order_details_dwh_order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "dwh_efooddelivery_api",
                        principalTable: "dwh_order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dwh_order_details_dwh_product_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "dwh_efooddelivery_api",
                        principalTable: "dwh_product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dwh_order_ClientId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_dwh_order_details_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_dwh_order_details_OrderId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dwh_order_details",
                schema: "dwh_efooddelivery_api");

            migrationBuilder.DropTable(
                name: "dwh_order",
                schema: "dwh_efooddelivery_api");

            migrationBuilder.InsertData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                columns: new[] { "Id", "Category", "Description", "Image", "Md_date", "Md_uuid", "Name", "Price", "Tag" },
                values: new object[,]
                {
                    { 1, "Almuerzo", "Receta de cocina con base de arroz, con origen en la actual Comunidad Valenciana, hoy en día muy popular en toda España y servida en restaurantes de todo el mundo.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/1.paella-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1244), new Guid("667be923-b4e6-41c4-b8a7-5dff53f89562"), "Paella Valenciana", 9.9499999999999993, "Mejor valorados" },
                    { 2, "Almuerzo", "Tortilla u omelet ​ a la que se le agrega patatas troceadas.​ Se trata de uno de los platos más conocidos y emblemáticos de la cocina española.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/2.tortilla-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1253), new Guid("88352e45-0d75-47e9-a61d-7ff6c9d32c94"), "Tortilla de Patatas", 7.9900000000000002, "Más vendidos" },
                    { 3, "Almuerzo", "​El salmorejo cordobés es una crema servida habitualmente como primer plato. Se elabora mediante una cierta cantidad de miga de pan,​ a la que se le incluye además ajo, aceite de oliva, sal y tomates.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/3.salmorejo-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1261), new Guid("10d87e26-b2ea-4c56-9410-3da8b82f3a8a"), "Salmorejo Cordobés", 6.4900000000000002, "Recomendados" },
                    { 4, "Almuerzo", "​Conjunto de hortalizas cocidas con unos aditamentos de carne, pescado y ave condimentada con una salsa mayonesa\", donde la remolacha, las judías verdes y las alcaparras forman parte de la receta.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/4.ensaladilla-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1280), new Guid("d8c504fe-28b8-4e9d-9186-77e642864437"), "Ensaladilla Rusa", 5.9500000000000002, "Más vendidos" },
                    { 5, "Almuerzo", "​Preparación culinaria de España y Portugal habitual de la gente que se dedica a la trashumancia española. Se elabora principalmente con pedazos de la miga de pan tostado acompañados de carnes y verduras.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/5.migas-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1287), new Guid("8faee55a-fe3c-4b12-b16b-be3f2438eaac"), "Migas Manchegas", 10.99, "Recomendados" },
                    { 6, "Cena", "​Se sirven generalmente como una tapa en muchos bares, o como raciones. Como algunos otros platos de marisco se suelen servir junto con una rodaja de limón.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/6.calamares-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1294), new Guid("8844044d-43cf-48a7-afc6-c854ed3d1261"), "Calamares a la Romana", 8.75, "Mejor valorados" },
                    { 7, "Cena", "​Se trata de un plato festivo elaborado con pulpo cocido entero (generalmente en ollas de cobre) que está presente en las fiestas, ferias y romerías de Galicia.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/7.pulpo-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1300), new Guid("5cf14c2b-76ee-48f0-b46a-7391fd41abad"), "Pulpo a la Gallega", 8.5, "Recomendados" },
                    { 8, "Almuerzo", "Guiso cuyo ingrediente principal son los garbanzos y los secundarios, aunque con gran protagonismo, diversas verduras, carnes y tocino de cerdo con algún embutido.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/8.cocido-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1310), new Guid("24052b73-cb25-457a-9258-9de381e24ce0"), "Cocido Madrileño", 9.9499999999999993, "Recomendados" },
                    { 9, "Cena", "​Porción de masa hecha de una salsa densa como la bechamel y un picadillo de diversos ingredientes, que ha sido rebozada en huevo y pan rallado, y frita en abundante aceite.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/9.croquetas-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1317), new Guid("27bd70e0-a88c-42ca-835b-0f31c06ce72e"), "Croquetas", 7.9900000000000002, "Más vendidos" },
                    { 10, "Postre", "​Plato hecho de una rebanada de pan (habitualmente de varios días) que es empapada en leche, almíbar o vino y, tras ser rebozada en huevo, se fríe en una sartén con aceite.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/10.torrijas-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1324), new Guid("553f5518-b978-4a90-ab54-6bd7e5c74538"), "Torrijas", 6.4500000000000002, "Mejor valorados" },
                    { 11, "Postre", "​Tipo de fruta de sartén que se suele servir como dulce navideño o de Semana Santa, típico de Andalucía y otras zonas de España, elaborado con masa de harina, frito en aceite de oliva y pasado por miel.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/11.pestiños-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1330), new Guid("81b5e39c-23f5-43a6-828d-379874f9a78a"), "Pestiños", 5.75, "Recomendados" },
                    { 12, "Desayuno", "​Es una fruta de sartén hecha de agua, harina (de trigo generalmente, aunque puede ser de otro origen), aceite y sal. Pueden tener formas de bastón, en lazos o rulos (espirales).", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/12.churros-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1340), new Guid("e88c852b-3713-4449-a7a8-0d45d213bb7f"), "Churros", 3.9900000000000002, "Más vendidos" },
                    { 13, "Postre", "​Tipo de fritura de sartén dulce propia de la repostería española realizado a base de harina cocida con leche y azúcar hasta que este preparado espesa, cortándose la masa resultante en porciones que posteriormente se fríen.", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/13.leche-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1347), new Guid("cd55d9ec-0e48-42ff-a86a-c8057fde69ba"), "Leche Frita", 4.75, "Recomendados" },
                    { 14, "Postre", "Son una receta dulce propia de Extremadura que se preparan desde Todos los Santos, pasando por Carnaval hasta Semana Santa. Se trata de una receta muy antigua que nos recuerda a las rosquillas por el tipo de masa.​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/14.huesillos-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1354), new Guid("bb2bb350-51f3-4a74-898a-e0e72bd52702"), "Huesillos Extremeños", 3.5, "Recomendados" },
                    { 15, "Bebidas", "​Lata de CocaCola de 33cl. CocaCola Zero (sin azúcar) o CocaCola Original", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/15.cocacola-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1361), new Guid("9599a220-352d-431c-8548-24e7f940b198"), "CocaCola", 1.5, "Más vendidos" },
                    { 16, "Bebidas", "Lata de Fanta de 33cl. Fanta de naranja o Fanta de limón​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/16.fanta-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1370), new Guid("b9df132f-8e10-4f32-9533-8815f98eb267"), "Fanta", 1.5, "Recomendados" },
                    { 17, "Bebidas", "Lata de 7up de 33cl. 7up free (sin azúcar) o 7up original​", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/17.7up-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1377), new Guid("0cee627f-045f-4016-b8cc-bc351c716a5a"), "7up", 1.5, "Recomendados" },
                    { 18, "Bebidas", "​Lata de Cruzcampo de 33cl. Cerveza Pilsen", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/18.cruzcampo-pilsen-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1384), new Guid("6fde262a-ddea-496c-a880-d637d88cd5f6"), "Cruzcampo Pilsen", 1.8, "Más vendidos" },
                    { 19, "Bebidas", "​Lata de Cruzcampo de 33cl. Cerveza Especial", "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/19.cruzcampo-especial-nobg.png", new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1391), new Guid("a65d20c3-cf05-4cae-9fb8-628bd3946cbd"), "Cruzcampo Especial", 1.8999999999999999, "Mejor valorados" }
                });
        }
    }
}
