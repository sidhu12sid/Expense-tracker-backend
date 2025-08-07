using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_tracker.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DESCRIPTION",
                table: "Expense",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "DATE",
                table: "Expense",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "CATEGORY",
                table: "Expense",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "AMOUNT",
                table: "Expense",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Expense",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UPDATED_DATE",
                table: "Expense",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "Expense",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CREATED_DATE",
                table: "Categories",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "CATEGORY_NAME",
                table: "Categories",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Otp = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Expense",
                newName: "DESCRIPTION");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Expense",
                newName: "DATE");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Expense",
                newName: "CATEGORY");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Expense",
                newName: "AMOUNT");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Expense",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Expense",
                newName: "UPDATED_DATE");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Expense",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Categories",
                newName: "CREATED_DATE");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "CATEGORY_NAME");
        }
    }
}
