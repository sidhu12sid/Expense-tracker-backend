using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_tracker.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CATEGORY_NAME = table.Column<string>(type: "TEXT", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Expense",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DESCRIPTION = table.Column<string>(type: "TEXT", nullable: true),
                    AMOUNT = table.Column<decimal>(type: "TEXT", nullable: false),
                    DATE = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CATEGORY = table.Column<string>(type: "TEXT", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expense", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Expense");
        }
    }
}
