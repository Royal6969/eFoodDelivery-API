using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m7cartItemsupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                schema: "dwh_efooddelivery_api",
                table: "dwh_cart");

            migrationBuilder.DropColumn(
                name: "PaymentAttempId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_cart");

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1244), new Guid("667be923-b4e6-41c4-b8a7-5dff53f89562") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1253), new Guid("88352e45-0d75-47e9-a61d-7ff6c9d32c94") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1261), new Guid("10d87e26-b2ea-4c56-9410-3da8b82f3a8a") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1280), new Guid("d8c504fe-28b8-4e9d-9186-77e642864437") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1287), new Guid("8faee55a-fe3c-4b12-b16b-be3f2438eaac") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1294), new Guid("8844044d-43cf-48a7-afc6-c854ed3d1261") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1300), new Guid("5cf14c2b-76ee-48f0-b46a-7391fd41abad") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1310), new Guid("24052b73-cb25-457a-9258-9de381e24ce0") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1317), new Guid("27bd70e0-a88c-42ca-835b-0f31c06ce72e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1324), new Guid("553f5518-b978-4a90-ab54-6bd7e5c74538") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1330), new Guid("81b5e39c-23f5-43a6-828d-379874f9a78a") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1340), new Guid("e88c852b-3713-4449-a7a8-0d45d213bb7f") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1347), new Guid("cd55d9ec-0e48-42ff-a86a-c8057fde69ba") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1354), new Guid("bb2bb350-51f3-4a74-898a-e0e72bd52702") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1361), new Guid("9599a220-352d-431c-8548-24e7f940b198") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1370), new Guid("b9df132f-8e10-4f32-9533-8815f98eb267") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1377), new Guid("0cee627f-045f-4016-b8cc-bc351c716a5a") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1384), new Guid("6fde262a-ddea-496c-a880-d637d88cd5f6") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 54, 6, 836, DateTimeKind.Local).AddTicks(1391), new Guid("a65d20c3-cf05-4cae-9fb8-628bd3946cbd") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                schema: "dwh_efooddelivery_api",
                table: "dwh_cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentAttempId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_cart",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
