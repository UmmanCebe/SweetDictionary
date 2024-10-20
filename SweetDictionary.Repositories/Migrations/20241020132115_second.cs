using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SweetDictionary.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedTime",
                value: new DateTime(2024, 10, 20, 16, 21, 14, 445, DateTimeKind.Local).AddTicks(4236));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1L,
                column: "CreatedTime",
                value: new DateTime(2024, 10, 19, 20, 54, 1, 44, DateTimeKind.Local).AddTicks(5761));
        }
    }
}
