using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloryApplication.Migrations
{
    /// <inheritdoc />
    public partial class Secondmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloryInGr",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Portion",
                table: "Products",
                newName: "CaloriesPer100gr");

            migrationBuilder.RenameColumn(
                name: "Carboh",
                table: "Products",
                newName: "Carbohydrates");

            migrationBuilder.CreateTable(
                name: "Calories_table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TotalConsumedCalories = table.Column<double>(type: "double", nullable: false),
                    TotalConsumeSquirrels = table.Column<double>(type: "double", nullable: false),
                    TotalConsumedCarbohydrates = table.Column<double>(type: "double", nullable: false),
                    TotalConsumedFats = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calories_table", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_ProductId",
                table: "Meals",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calories_table");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates",
                table: "Products",
                newName: "Carboh");

            migrationBuilder.RenameColumn(
                name: "CaloriesPer100gr",
                table: "Products",
                newName: "Portion");

            migrationBuilder.AddColumn<int>(
                name: "CaloryInGr",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
