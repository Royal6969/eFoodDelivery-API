using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eFoodDelivery_API.Migrations
{
    /// <inheritdoc />
    public partial class m1identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dlk_efooddelivery_api");

            migrationBuilder.CreateTable(
                name: "dlk_roles",
                schema: "dlk_efooddelivery_api",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dlk_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dlk_users",
                schema: "dlk_efooddelivery_api",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dlk_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dlk_role_claim",
                schema: "dlk_efooddelivery_api",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dlk_role_claim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dlk_role_claim_dlk_roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dlk_efooddelivery_api",
                        principalTable: "dlk_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dlk_user_claim",
                schema: "dlk_efooddelivery_api",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dlk_user_claim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dlk_user_claim_dlk_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dlk_efooddelivery_api",
                        principalTable: "dlk_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dlk_user_login",
                schema: "dlk_efooddelivery_api",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dlk_user_login", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_dlk_user_login_dlk_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dlk_efooddelivery_api",
                        principalTable: "dlk_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dlk_user_roles",
                schema: "dlk_efooddelivery_api",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dlk_user_roles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_dlk_user_roles_dlk_roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dlk_efooddelivery_api",
                        principalTable: "dlk_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dlk_user_roles_dlk_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dlk_efooddelivery_api",
                        principalTable: "dlk_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dlk_user_tokens",
                schema: "dlk_efooddelivery_api",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dlk_user_tokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_dlk_user_tokens_dlk_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "dlk_efooddelivery_api",
                        principalTable: "dlk_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dlk_role_claim_RoleId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_role_claim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dlk_efooddelivery_api",
                table: "dlk_roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_dlk_user_claim_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_claim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_dlk_user_login_UserId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_login",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_dlk_user_roles_RoleId",
                schema: "dlk_efooddelivery_api",
                table: "dlk_user_roles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dlk_efooddelivery_api",
                table: "dlk_users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dlk_role_claim",
                schema: "dlk_efooddelivery_api");

            migrationBuilder.DropTable(
                name: "dlk_user_claim",
                schema: "dlk_efooddelivery_api");

            migrationBuilder.DropTable(
                name: "dlk_user_login",
                schema: "dlk_efooddelivery_api");

            migrationBuilder.DropTable(
                name: "dlk_user_roles",
                schema: "dlk_efooddelivery_api");

            migrationBuilder.DropTable(
                name: "dlk_user_tokens",
                schema: "dlk_efooddelivery_api");

            migrationBuilder.DropTable(
                name: "dlk_roles",
                schema: "dlk_efooddelivery_api");

            migrationBuilder.DropTable(
                name: "dlk_users",
                schema: "dlk_efooddelivery_api");
        }
    }
}
