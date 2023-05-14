using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m12updatingimagescontainer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/1.paella-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5665), new Guid("501bd70b-6d50-4706-8c26-640ab79bd3f9") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/2.tortilla-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5674), new Guid("33a344db-ce9e-44a8-9f58-8b4b69eefb32") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/3.salmorejo-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5692), new Guid("7f919663-bf5e-4799-bc10-0b6985bd48bc") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/4.ensaladilla-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5698), new Guid("a87fa6f6-aeb0-4a10-b974-bc000f7e1b40") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/5.migas-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5752), new Guid("893dd8a3-5a76-4981-8360-901d3c11fed8") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/6.calamares-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5759), new Guid("e8fcfd0d-1700-4c4b-846e-fc0b994a79bd") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/7.pulpo-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5768), new Guid("36220a7a-fe79-4e88-81f3-feaebcbb1093") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/8.cocido-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5775), new Guid("a6f7a1ee-82c0-4fed-95c1-72aab59fc6de") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/9.croquetas-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5781), new Guid("eccaa943-c812-4e78-af3c-bb665e0fa072") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/10.torrijas-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5787), new Guid("a0056dc9-2803-4cc0-ba95-477189aa1d77") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/11.pestiños-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5795), new Guid("1b680611-42dc-45f2-a28f-60f16892db7f") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/12.churros-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5801), new Guid("f3c29075-d517-43eb-bcba-93a475d7f548") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/13.leche-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5807), new Guid("9228989d-6766-4f53-bbd1-a970cb587989") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/14.huesillos-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5813), new Guid("30ce20d8-9152-469e-b2bb-4b80a653b3b4") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/15.cocacola-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5821), new Guid("854be030-81c1-4163-bbe3-a787d9b8ad19") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/16.fanta-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5827), new Guid("d8c58d8f-aa61-43fe-8110-a710a6b2f732") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/17.7up-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5833), new Guid("a30c6836-e360-456f-9256-320b6dad327b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/18.cruzcampo-pilsen-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5839), new Guid("abd5123c-f911-4b3d-9744-4076ffcf7de4") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimagenes.blob.core.windows.net/efooddelivery-contenedor-imagenes/19.cruzcampo-especial-nobg.png", new DateTime(2023, 4, 24, 15, 30, 3, 217, DateTimeKind.Local).AddTicks(5847), new Guid("dab3e925-2c19-4446-bd68-3393ebd97c76") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/1.paella-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(887), new Guid("9c444643-e4e2-437d-8c03-8957477ec2c7") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/2.tortilla-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(896), new Guid("57ba30a1-7c31-403d-9b50-ec5f3fd568a3") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/3.salmorejo-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(915), new Guid("204352ef-1ea9-4587-b886-aa48eb9c9f85") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/4.ensaladilla-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(922), new Guid("ad47ad4a-25e3-41ec-b357-a282263abc2c") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/5.migas-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(928), new Guid("cec1979f-9bd5-4276-a2d3-4112b537505e") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/6.calamares-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(935), new Guid("133e5d07-81fe-43e8-aa28-49c9ba82f3e4") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/7.pulpo-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(945), new Guid("213d1d40-7b95-4013-aa87-59f12e1b6caa") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/8.cocido-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(953), new Guid("d60a84fb-c606-4a60-9afd-be51c7974c61") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/9.croquetas-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(959), new Guid("b8037ce9-6b6b-476c-8dd7-1ce0d49da235") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/10.torrijas-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(965), new Guid("e9e7a998-29d0-42ba-881c-9935392168e6") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/11.pestiños-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(974), new Guid("05bd4eeb-8d71-409b-8502-a000627eb6cf") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/12.churros-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(980), new Guid("10942c83-1f9f-4ff4-b367-2d39b9af11e5") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/13.leche-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(986), new Guid("e64efde9-74ca-4f32-ac21-b95aa7568e5b") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/14.huesillos-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(993), new Guid("c6133384-8657-436e-8e8b-2f4e6868fded") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/15.cocacola-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1001), new Guid("912d423b-8ca0-40e9-a3e6-ceb7e25b2bcb") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/16.fanta-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1008), new Guid("0bc62100-9088-4fe4-9aba-81b42142b0bc") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/17.7up-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1014), new Guid("2e6690a6-6c1e-48d4-9738-257a3a13ee98") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/18.cruzcampo-pilsen-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1021), new Guid("cfa99996-56f8-405b-9132-1af4fd9205a1") });

            migrationBuilder.UpdateData(
                schema: "dwh_efooddelivery_api",
                table: "dwh_product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Image", "Md_date", "Md_uuid" },
                values: new object[] { "https://efooddeliveryimages.blob.core.windows.net/efooddelivery-images/19.cruzcampo-especial-nobg.png", new DateTime(2023, 4, 3, 12, 6, 0, 530, DateTimeKind.Local).AddTicks(1030), new Guid("ecbff882-013b-482b-a396-241170acf6fb") });
        }
    }
}
