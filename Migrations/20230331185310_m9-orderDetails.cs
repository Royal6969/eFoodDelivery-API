using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m9orderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dwh_order_details_dwh_order_OrderId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details");

            migrationBuilder.DropForeignKey(
                name: "FK_dwh_order_details_dwh_product_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dwh_order_details",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details");

            migrationBuilder.RenameTable(
                name: "dwh_order_details",
                schema: "dwh_efooddelivery_api",
                newName: "dwh_orderDetails",
                newSchema: "dwh_efooddelivery_api");

            migrationBuilder.RenameIndex(
                name: "IX_dwh_order_details_OrderId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "IX_dwh_orderDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_dwh_order_details_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                newName: "IX_dwh_orderDetails_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dwh_orderDetails",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_dwh_orderDetails_dwh_order_OrderId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails",
                column: "OrderId",
                principalSchema: "dwh_efooddelivery_api",
                principalTable: "dwh_order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dwh_orderDetails_dwh_order_OrderId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_dwh_orderDetails_dwh_product_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dwh_orderDetails",
                schema: "dwh_efooddelivery_api",
                table: "dwh_orderDetails");

            migrationBuilder.RenameTable(
                name: "dwh_orderDetails",
                schema: "dwh_efooddelivery_api",
                newName: "dwh_order_details",
                newSchema: "dwh_efooddelivery_api");

            migrationBuilder.RenameIndex(
                name: "IX_dwh_orderDetails_OrderId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details",
                newName: "IX_dwh_order_details_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_dwh_orderDetails_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details",
                newName: "IX_dwh_order_details_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dwh_order_details",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_dwh_order_details_dwh_order_OrderId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details",
                column: "OrderId",
                principalSchema: "dwh_efooddelivery_api",
                principalTable: "dwh_order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dwh_order_details_dwh_product_ItemId",
                schema: "dwh_efooddelivery_api",
                table: "dwh_order_details",
                column: "ItemId",
                principalSchema: "dwh_efooddelivery_api",
                principalTable: "dwh_product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
