using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m13updatingOrderDetailsCreateDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dwh_orderDetails_dwh_product_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails");

            migrationBuilder.RenameColumn(
                name: "ItemQuantity",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ItemPrice",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_dwh_orderDetails_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "IX_dwh_orderDetails_ProductId");

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1341), new Guid("bed609a1-fcae-4bed-b27c-38fa15f88e52") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1367), new Guid("adff5188-f53b-490a-bc7b-9b5bd8eb97bf") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1383), new Guid("f4d4827c-19b2-4006-bafa-ea07f67c3990") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1411), new Guid("e5fc5a96-07c7-45f4-b5a3-006d6ff47220") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1426), new Guid("58aa71be-6fec-4149-997b-d64fffb84dc5") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1448), new Guid("89757093-b703-484d-82d4-d8c89331aaae") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1467), new Guid("5f924a10-005a-452c-af63-09c3e2a80e9c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1489), new Guid("00b60435-f9e6-4871-8081-07d2aadf5891") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1508), new Guid("203d6d29-7801-4255-b9c7-be73e254eceb") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1524), new Guid("e8503e4d-9697-4ad9-92ca-7ddfa856eca2") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1539), new Guid("c54b3720-cb86-4da9-9e7b-91a9fc6e6819") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1568), new Guid("15874cde-e333-41e8-8aab-2557f468d01c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1587), new Guid("53d375dd-4556-4210-846b-d4cf2fe559ea") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1601), new Guid("66261058-4335-45cd-96d7-22824f7af620") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1621), new Guid("af54f242-c76a-421d-8d09-5c8e9c08308e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1643), new Guid("a16ddea9-93c9-4510-a280-aecfca0c08d9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1660), new Guid("5cce9e37-e5e1-40f4-92f8-03f642193bca") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1678), new Guid("c9530023-6500-4d41-8da2-1795c57178db") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 14, 14, 9, 5, 807, DateTimeKind.Local).AddTicks(1694), new Guid("8710a70d-dbb4-4d7a-a581-16c4ac7bb41f") });

            migrationBuilder.AddForeignKey(
                name: "FK_dwh_orderDetails_dwh_product_ProductId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                column: "ProductId",
                principalSchema: "dwh_efooddelivery_api",
                principalTable: "dwh_product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dwh_orderDetails_dwh_product_ProductId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "ItemQuantity");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "Price",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "ItemPrice");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "ItemName");

            migrationBuilder.RenameIndex(
                name: "IX_dwh_orderDetails_ProductId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "IX_dwh_orderDetails_ItemId");

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5665), new Guid("501bd70b-6d50-4706-8c26-640ab79bd3f9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5674), new Guid("33a344db-ce9e-44a8-9f58-8b4b69eefb32") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5692), new Guid("7f919663-bf5e-4799-bc10-0b6985bd48bc") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5698), new Guid("a87fa6f6-aeb0-4a10-b974-bc000f7e1b40") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5752), new Guid("893dd8a3-5a76-4981-8360-901d3c11fed8") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5759), new Guid("e8fcfd0d-1700-4c4b-846e-fc0b994a79bd") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5768), new Guid("36220a7a-fe79-4e88-81f3-feaebcbb1093") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5775), new Guid("a6f7a1ee-82c0-4fed-95c1-72aab59fc6de") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5781), new Guid("eccaa943-c812-4e78-af3c-bb665e0fa072") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5787), new Guid("a0056dc9-2803-4cc0-ba95-477189aa1d77") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5795), new Guid("1b680611-42dc-45f2-a28f-60f16892db7f") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5801), new Guid("f3c29075-d517-43eb-bcba-93a475d7f548") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5807), new Guid("9228989d-6766-4f53-bbd1-a970cb587989") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5813), new Guid("30ce20d8-9152-469e-b2bb-4b80a653b3b4") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5821), new Guid("854be030-81c1-4163-bbe3-a787d9b8ad19") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5827), new Guid("d8c58d8f-aa61-43fe-8110-a710a6b2f732") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5833), new Guid("a30c6836-e360-456f-9256-320b6dad327b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5839), new Guid("abd5123c-f911-4b3d-9744-4076ffcf7de4") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5847), new Guid("dab3e925-2c19-4446-bd68-3393ebd97c76") });

            migrationBuilder.AddForeignKey(
                name: "FK_dwh_orderDetails_dwh_product_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                column: "ItemId",
                principalSchema: "dwh_efooddelivery_api",
                principalTable: "dwh_product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
