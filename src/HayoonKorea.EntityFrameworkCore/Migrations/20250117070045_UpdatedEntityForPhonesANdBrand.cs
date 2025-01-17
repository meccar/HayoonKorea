using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HayoonKorea.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEntityForPhonesANdBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppPhones_AppBrands_BrandId1",
                table: "AppPhones");

            migrationBuilder.DropIndex(
                name: "IX_AppPhones_BrandId1",
                table: "AppPhones");

            migrationBuilder.DropColumn(
                name: "BrandId1",
                table: "AppPhones");

            migrationBuilder.RenameColumn(
                name: "ram",
                table: "AppPhones",
                newName: "Ram");

            migrationBuilder.AlterColumn<float>(
                name: "Width",
                table: "AppPhones",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "AppPhones",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Depth",
                table: "AppPhones",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ram",
                table: "AppPhones",
                newName: "ram");

            migrationBuilder.AlterColumn<int>(
                name: "Width",
                table: "AppPhones",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "AppPhones",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Depth",
                table: "AppPhones",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AddColumn<Guid>(
                name: "BrandId1",
                table: "AppPhones",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_AppPhones_BrandId1",
                table: "AppPhones",
                column: "BrandId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AppPhones_AppBrands_BrandId1",
                table: "AppPhones",
                column: "BrandId1",
                principalTable: "AppBrands",
                principalColumn: "Id");
        }
    }
}
