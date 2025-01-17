using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayoonKorea.Migrations
{
    /// <inheritdoc />
    public partial class Brand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BrandId1",
                table: "AppPhones",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "AppBrands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBrands", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AppPhones_BrandId",
                table: "AppPhones",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPhones_BrandId1",
                table: "AppPhones",
                column: "BrandId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AppPhones_AppBrands_BrandId",
                table: "AppPhones",
                column: "BrandId",
                principalTable: "AppBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppPhones_AppBrands_BrandId1",
                table: "AppPhones",
                column: "BrandId1",
                principalTable: "AppBrands",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppPhones_AppBrands_BrandId",
                table: "AppPhones");

            migrationBuilder.DropForeignKey(
                name: "FK_AppPhones_AppBrands_BrandId1",
                table: "AppPhones");

            migrationBuilder.DropTable(
                name: "AppBrands");

            migrationBuilder.DropIndex(
                name: "IX_AppPhones_BrandId",
                table: "AppPhones");

            migrationBuilder.DropIndex(
                name: "IX_AppPhones_BrandId1",
                table: "AppPhones");

            migrationBuilder.DropColumn(
                name: "BrandId1",
                table: "AppPhones");
        }
    }
}
