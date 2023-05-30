using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m14addcodefield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8903), new Guid("56d2f2b3-911d-4ef1-b629-654a1768a97b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8912), new Guid("8aafcb1e-15e3-40fa-b8de-68a2ac2a6c54") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8919), new Guid("f83ebbb8-7076-4a6b-aaf1-6231f3d1b78e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8926), new Guid("7773d882-2f0b-4d3d-9a3e-45c084c0a98e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8936), new Guid("258118bc-5cbd-4b4c-a6cb-b869bf5f7c99") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8943), new Guid("f969a0db-8005-466a-bb61-460bbd136d2b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8950), new Guid("b018a082-10bc-499b-bbb1-906c91e26b6f") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8956), new Guid("0fea3536-2398-4445-941e-23765af86cc8") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8965), new Guid("865836fb-d74b-49f6-9ec4-0f2be2d3e6f2") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8972), new Guid("84940c74-2e3e-4fc7-bf43-cdf47fccd149") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8979), new Guid("40c9e9be-5667-4d24-a389-53d82a4777d8") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8986), new Guid("e262d2ac-f8f0-4391-9480-e8dc0e78735c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(8995), new Guid("c3962db5-1cff-4b9c-aee3-eab597e98a40") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9002), new Guid("9d88f6bd-9f21-4fe8-abd1-aee19d646fe9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9009), new Guid("5a0c7151-6f92-4fa5-b12e-ddcd9ce03f1e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9016), new Guid("5ba2d014-bfde-445e-b03d-762820c9e3b1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9025), new Guid("1289ef02-8ac7-474b-8a08-96fc957db2a5") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9031), new Guid("26e158e3-28ed-4007-87df-e3b46ee53256") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 29, 18, 8, 24, 174, DateTimeKind.Local).AddTicks(9038), new Guid("946b01b6-b24b-4689-99c9-c4551f9991fb") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users");

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
        }
    }
}
