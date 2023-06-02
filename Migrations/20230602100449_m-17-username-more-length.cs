using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m17usernamemorelength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(102), new Guid("728d4549-2eb4-4d8d-b893-c9cbf05e0fa6") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(111), new Guid("2abd9464-ed6d-4c04-a086-1f00d117496b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(120), new Guid("f4d7d705-9ab8-4033-8b2e-8c9b4850c0cd") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(142), new Guid("327acc4f-d10d-4cb9-b34e-8209c5816bb7") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(148), new Guid("75cf1bfe-92aa-4efa-b475-8bd4cdfb2e47") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(155), new Guid("176fe18c-9d33-4ef6-99e3-e7c259a8ebb0") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(162), new Guid("0cca207f-19e9-4236-96bd-c34cacde1ec7") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(171), new Guid("16d6f62a-9cec-44fb-be82-5ecdb4a76120") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(179), new Guid("1246d7ed-708d-4ca3-a4e0-720065bf91cc") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(185), new Guid("48794d3a-81ab-4b33-ac30-b5b3350dcb87") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(191), new Guid("2f65a6a3-0df9-408b-85f1-8f0a3353492c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(199), new Guid("de3ba6f4-970a-4298-b663-70cd091ff6b3") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(205), new Guid("70ee366e-df37-4ac5-a2b7-da7a3087d4b8") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(210), new Guid("da15f85f-2a6f-4501-a4a6-a1e37f0323f1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(217), new Guid("c6bd5ffd-8e80-45ae-9d4c-ffa44f340e85") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(226), new Guid("46900ee3-e685-468b-8b1c-c4c97c4eb4ea") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(232), new Guid("8b104663-6aca-4645-98f9-b43719936c62") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(246), new Guid("73b2949a-9b21-45b1-9b5c-b18fb4a22695") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Md_date", "Md_uuid" },
                values: new object[] { new DateTime(2023, 6, 2, 12, 4, 49, 6, DateTimeKind.Local).AddTicks(253), new Guid("3d390980-965c-46c2-8215-adf5d5cc1135") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

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
    }
}
