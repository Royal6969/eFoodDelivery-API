using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m6cartItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dwh_cart",
                schema: "dwh_efooddelivery_api",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Md_uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Md_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAttempId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientSecret = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dwh_cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dwh_cartItem",
                schema: "dwh_efooddelivery_api",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Md_uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Md_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dwh_cartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dwh_cartItem_dwh_cart_CartId",
                        column: x => x.CartId,
                        principalSchema: "dwh_efooddelivery_api",
                        principalTable: "dwh_cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dwh_cartItem_dwh_product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "dwh_efooddelivery_api",
                        principalTable: "dwh_product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5222), new Guid("95b07eab-1e22-4f8f-8130-7c018a9aca6d") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5231), new Guid("b3dd254c-0280-4539-9ec3-f1a4564d5c38") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5248), new Guid("dd960ba6-6f3d-4dcf-81f8-a047371d61b4") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5256), new Guid("20572bb3-78cb-476d-a3ba-4d8dbd51248f") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5263), new Guid("eee34e0c-4334-49ac-ab91-c4fcf3053e27") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5271), new Guid("15fa731a-9b3a-4970-96b6-5c1de47ba8f0") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5281), new Guid("c401674f-f01d-4b63-b33f-ca9c8ecefe2a") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5288), new Guid("44372a18-d475-4be2-92f7-e9d0af146ac2") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5295), new Guid("7820d3fb-00f8-4e93-ab57-280dbc664d71") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5302), new Guid("2260edd1-7d03-44af-bdc4-1085499f6028") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5311), new Guid("87277802-f255-4bfc-8e2a-2cb106f04233") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5319), new Guid("efbe4a50-a405-4439-8202-91829308e19e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5325), new Guid("9641f660-ca77-423a-9351-a8cbb609f7c3") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5332), new Guid("1719382e-453b-4b6c-9d4b-34b0bb9f59ca") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5342), new Guid("5dc463f0-68d8-4a21-9750-1eaa24ac9d7e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5348), new Guid("ba7e5899-eb59-41af-87a9-35c18051e6ec") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5355), new Guid("a4914410-c4d3-4556-800f-5e3edefb58a3") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5362), new Guid("e8956d00-90ec-4371-9ee6-da5225b6ef4b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 43, 54, 904, DateTimeKind.Local).AddTicks(5371), new Guid("d3db638c-f01a-4d02-9ac6-88a1dd4cd531") });

            migrationBuilder.CreateIndex(
                name: "IX_dwh_cartItem_CartId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_cartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_dwh_cartItem_ProductId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_cartItem",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dwh_cartItem",
                schema: "dwh_efooddelivery_api");

            migrationBuilder.DropTable(
                name: "dwh_cart",
                schema: "dwh_efooddelivery_api");

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6743), new Guid("f27b5282-b301-4009-8a48-8ae4cc29b994") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6752), new Guid("7fd15c0a-f004-460e-8be2-2857197a1f6f") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6759), new Guid("cf49257d-247b-40f7-86bd-b2481c83c83b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6766), new Guid("6310b860-6bf3-4eda-975f-3940da8c8459") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6777), new Guid("dd68e400-b4eb-4aa1-ac5b-60fb17b700eb") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6784), new Guid("21afdf5b-0532-495b-8ac6-c399868a7e26") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6791), new Guid("28c2505d-3363-4a66-8522-963e1faf07af") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6798), new Guid("ac9cc286-c486-4041-bc7a-4bc219ebf765") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6807), new Guid("e1d59bcd-811f-43c8-ac96-946820db6d26") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6813), new Guid("87ab2a3b-4756-40e6-ae8b-202fdb100774") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6820), new Guid("9acf9c8e-52f6-4db2-8577-00a6ca6e6d85") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6826), new Guid("8c332008-5379-4d26-bdba-e79f2b09dedd") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6835), new Guid("ac3432f9-c5ee-4399-96d0-0b7d0e2e0b9c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6841), new Guid("30bf4be4-4745-425e-af3b-bd762e178e2b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6858), new Guid("0a33de20-dd35-4fcb-8789-924a038f423e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6864), new Guid("9385c08d-87d2-46e0-8180-4845a524c2f9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6872), new Guid("61fc32ad-85a4-4896-87af-a0ce92fe5e09") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6879), new Guid("f3784487-fe43-4ee5-b47c-1d8cb7e43d12") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 42, 17, 876, DateTimeKind.Local).AddTicks(6885), new Guid("73882b0f-23fb-46b9-b95a-b2d4839c2451") });
        }
    }
}
