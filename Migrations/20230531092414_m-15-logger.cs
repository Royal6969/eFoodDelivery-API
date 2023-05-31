using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m15logger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dwh_logger",
                schema: "dwh_efooddelivery_api",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Md_uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Md_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Log = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dwh_logger", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6051), new Guid("2c25518a-51a5-4bfb-aba6-d464b22988d4") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6066), new Guid("8ef27b17-aa8b-4ddd-83c4-b1fb8b6a3b7e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6076), new Guid("81a1cccf-b5eb-4bf9-a42d-f9ff8c3cea81") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6084), new Guid("31239505-f91e-42c4-9b39-e6d188694dc1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6094), new Guid("3ad20a4a-1b71-45ef-a8af-87b818f51875") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6101), new Guid("ec8ae9fe-c23d-4e4b-abf5-7e59e1414eb6") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6108), new Guid("98f08372-e4a2-48b5-ba1d-e389fc9ecb77") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6114), new Guid("3d5ed739-dec2-4744-830c-1c3a41a87a6c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6124), new Guid("b1b96034-5364-4147-a326-1f7f4e78cd0d") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6131), new Guid("1ff217dd-3fb7-4863-9961-fc73e1ae910b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6138), new Guid("9b68b210-8003-4b41-a39e-eb6ab802d6da") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6144), new Guid("e34c20ce-f14a-4637-9cdb-99c48cf1b936") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6153), new Guid("c72370f2-e5fb-4d74-a4a7-3760981af605") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6160), new Guid("883463e0-1d9e-4ac0-9891-5e3441abeec1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6167), new Guid("21360f49-103d-4201-a072-2d17e75520da") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6174), new Guid("2a6a30e6-3278-475c-b978-33e1382adc73") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6183), new Guid("8714a0d4-4ff3-43a1-af40-0e228efe6bfc") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6189), new Guid("5a60c094-e0b8-456c-b80d-c230c1559ae8") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 24, 14, 420, DateTimeKind.Local).AddTicks(6196), new Guid("17bf0ddc-59aa-47e0-bb9b-16e8bd73bf14") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dwh_logger",
                schema: "dwh_efooddelivery_api");

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
    }
}
