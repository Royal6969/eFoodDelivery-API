using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m16loggeraddinglevelfield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Level",
                schema: "dwh_efooddelivery_api",
                table: "dwh_logger",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8108), new Guid("b2121aa1-d283-41a2-a9c9-96455ad6fd55") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8129), new Guid("b1bc2366-4038-4d88-a93e-8ab96ebfc215") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8136), new Guid("ca8a2902-71c9-427c-bff1-828e5d45616c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8143), new Guid("0ea9bd77-327f-4313-a195-6f049c183ca1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8148), new Guid("0fbf47c7-0cf2-4956-9d30-9e02ee9295c8") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8159), new Guid("8e315a68-3c2f-4630-8cf2-1b8e8baa32c9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8165), new Guid("3bc7649f-4e45-45d4-8167-42d1572576b7") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8171), new Guid("42c39b08-2457-462c-905d-04c778aabff3") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8177), new Guid("4b5694e0-9adf-46da-b133-2ef44dff87ed") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8185), new Guid("2eb34878-b577-4eba-b434-f3eda8af36fe") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8191), new Guid("ac56aac0-b8ed-4f0b-8fea-8ae708763c72") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8203), new Guid("ce142116-8b1d-47a6-baab-79dd7ceec73f") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8263), new Guid("42334cfb-9d2d-4f5f-ba90-1c859105858a") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8272), new Guid("3117327f-374e-4fd9-8e9f-e46e60bc2905") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8278), new Guid("231d0d16-a73b-4740-9cf9-b23696dc64f9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8284), new Guid("9ebadd99-19fc-41af-9b23-9687ef525d75") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8290), new Guid("cc7c731f-d8cc-43b6-ab5c-7186018fd4b8") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8298), new Guid("f45e4e02-b09d-4fe1-aecd-69fddb41beaa") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 5, 31, 12, 24, 46, 187, DateTimeKind.Local).AddTicks(8304), new Guid("8e43f80f-b916-4501-98c6-839480463bbd") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                schema: "dwh_efooddelivery_api",
                table: "dwh_logger");

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
    }
}
