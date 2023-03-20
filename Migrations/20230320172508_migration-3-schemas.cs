using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class migration3schemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.EnsureSchema(
                name: "dlk_efooddelivery_api");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "dlk_user_tokens",
                newSchema: "dlk_efooddelivery_api");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "dlk_users",
                newSchema: "dlk_efooddelivery_api");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "dlk_user_roles",
                newSchema: "dlk_efooddelivery_api");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "dlk_user_login",
                newSchema: "dlk_efooddelivery_api");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "dlk_user_claim",
                newSchema: "dlk_efooddelivery_api");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "dlk_roles",
                newSchema: "dlk_efooddelivery_api");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "dlk_role_claim",
                newSchema: "dlk_efooddelivery_api");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_roles",
                newName: "IX_dlk_user_roles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_login",
                newName: "IX_dlk_user_login_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_claim",
                newName: "IX_dlk_user_claim_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_role_claim",
                newName: "IX_dlk_role_claim_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_dlk_user_tokens",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_tokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_dlk_users",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dlk_user_roles",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_roles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_dlk_user_login",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_login",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_dlk_user_claim",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_claim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dlk_roles",
                schema: "dlk_efooddelivery_api",
                table: "dlk_roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dlk_role_claim",
                schema: "dlk_efooddelivery_api",
                table: "dlk_role_claim",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dlk_role_claim_dlk_roles_RoleId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_role_claim",
                column: "RoleId",
                principalSchema: "dlk_efooddelivery_api",
                principalTable: "dlk_roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dlk_user_claim_dlk_users_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_claim",
                column: "UserId",
                principalSchema: "dlk_efooddelivery_api",
                principalTable: "dlk_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dlk_user_login_dlk_users_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_login",
                column: "UserId",
                principalSchema: "dlk_efooddelivery_api",
                principalTable: "dlk_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dlk_user_roles_dlk_roles_RoleId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_roles",
                column: "RoleId",
                principalSchema: "dlk_efooddelivery_api",
                principalTable: "dlk_roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dlk_user_roles_dlk_users_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_roles",
                column: "UserId",
                principalSchema: "dlk_efooddelivery_api",
                principalTable: "dlk_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_dlk_user_tokens_dlk_users_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_tokens",
                column: "UserId",
                principalSchema: "dlk_efooddelivery_api",
                principalTable: "dlk_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dlk_role_claim_dlk_roles_RoleId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_role_claim");

            migrationBuilder.DropForeignKey(
                name: "FK_dlk_user_claim_dlk_users_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_claim");

            migrationBuilder.DropForeignKey(
                name: "FK_dlk_user_login_dlk_users_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_login");

            migrationBuilder.DropForeignKey(
                name: "FK_dlk_user_roles_dlk_roles_RoleId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_dlk_user_roles_dlk_users_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_dlk_user_tokens_dlk_users_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dlk_users",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dlk_user_tokens",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dlk_user_roles",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dlk_user_login",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_login");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dlk_user_claim",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_claim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dlk_roles",
                schema: "dlk_efooddelivery_api",
                table: "dlk_roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dlk_role_claim",
                schema: "dlk_efooddelivery_api",
                table: "dlk_role_claim");

            migrationBuilder.RenameTable(
                name: "dlk_users",
                schema: "dlk_efooddelivery_api",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "dlk_user_tokens",
                schema: "dlk_efooddelivery_api",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "dlk_user_roles",
                schema: "dlk_efooddelivery_api",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "dlk_user_login",
                schema: "dlk_efooddelivery_api",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "dlk_user_claim",
                schema: "dlk_efooddelivery_api",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "dlk_roles",
                schema: "dlk_efooddelivery_api",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "dlk_role_claim",
                schema: "dlk_efooddelivery_api",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_dlk_user_roles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_dlk_user_login_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_dlk_user_claim_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_dlk_role_claim_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
