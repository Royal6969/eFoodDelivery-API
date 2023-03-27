using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m4producttableupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                schema: "dwh_efooddelivery_api",
                table: "product");

            migrationBuilder.RenameTable(
                name: "product",
                schema: "dwh_efooddelivery_api",
                newName: "dwh_product",
                newSchema: "dwh_efooddelivery_api");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dwh_product",
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2040), new Guid("314a4412-8ad6-4260-905a-90cb3d740bdf") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2049), new Guid("a65a7607-0f46-4566-a491-33205db7a3fb") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2070), new Guid("df3f4204-0ed8-465e-a03f-65118de181e6") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2077), new Guid("d50b4b2e-4694-4824-816d-11716917070d") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2084), new Guid("ad3aea09-18d1-4d48-9673-854f90cde387") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2091), new Guid("253321dc-40bb-46eb-ac0b-44f5dee5fbd9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2101), new Guid("c5697cc4-c8fd-4b9a-b51f-04722724096a") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2108), new Guid("02b2439b-69b7-4b43-b610-5ecec51fe5c2") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2115), new Guid("95af8f01-5f44-44a2-b591-3b01e3b72e34") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2122), new Guid("358001f5-2811-4737-8a05-5491d8d2987a") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2131), new Guid("d801ce69-eca3-4207-9de5-578bd966ff06") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2138), new Guid("0eb90791-c92c-46c2-9843-debb18bead56") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2145), new Guid("60276635-ff0e-4fcc-825c-ddbeefb8859d") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2152), new Guid("f57d0afa-086f-477e-af0c-d641091f8fa1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2161), new Guid("88d9c66d-d2d5-4a94-bc0e-3e4bbd4dda14") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2167), new Guid("d3de7271-b28e-4e2c-84c1-7cff91b49ffd") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2174), new Guid("8a116297-74f3-49ca-88f9-6ffd03402fd1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2181), new Guid("844f23e1-73ac-4b95-ae9b-624e6d9e410a") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 27, 9, 40, 8, 856, DateTimeKind.Local).AddTicks(2191), new Guid("681574b6-127a-4c37-92cf-84f8a1efaea9") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_dwh_product",
                schema: "dwh_efooddelivery_api",
                table: "dwh_product");

            migrationBuilder.RenameTable(
                name: "dwh_product",
                schema: "dwh_efooddelivery_api",
                newName: "product",
                newSchema: "dwh_efooddelivery_api");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                schema: "dwh_efooddelivery_api",
                table: "product",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8027), new Guid("a53cf779-73a4-470a-8d5e-2cdbc2ece0c9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8038), new Guid("df8e8a16-9043-4f79-9481-08f443e12a48") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8062), new Guid("7e095895-52d6-490b-aabe-eb8eaa58fe2d") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8072), new Guid("5d059545-bceb-4fdf-85b0-733e4c656aa3") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8105), new Guid("66f5ba45-842c-4491-b229-fd6389e22472") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8115), new Guid("fb95596a-1aa5-42aa-94b1-14849a3f224b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8127), new Guid("bd719ccb-79ac-473d-b8fa-2d2e137a62f1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8133), new Guid("4a781810-f311-482d-8fa6-1ee2b69b78ad") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8149), new Guid("57de4cf5-4be3-4c72-bd33-11f1fcd380e6") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8155), new Guid("d381efce-780c-4a59-8b5e-58291f4343fb") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8164), new Guid("8a6e3b3c-bab4-459e-ad0b-ec2373e0367f") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8170), new Guid("3e46e184-0ca7-4c34-8e2c-bd810173c22d") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8177), new Guid("4f7fe882-5f1a-4684-a2c4-fa512cca72c0") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8184), new Guid("bdf7e8a1-3b59-45fc-9b3f-88b62893e7a3") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8192), new Guid("ff1a6101-2265-4a7e-9d38-dd5c4873d4ba") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8199), new Guid("00096934-06c3-45e2-968b-a0bcecff5cc5") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8205), new Guid("c6f8ef0f-fa2a-4f7e-8363-30e832e2636c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8212), new Guid("176b150e-bb6f-466b-a69a-8a3b1096c85b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 17, 51, 734, DateTimeKind.Local).AddTicks(8220), new Guid("92d4ded8-1a4a-44eb-ac82-31e9b1132883") });
        }
    }
}
