using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookMania.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialinq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Inquiry");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Inquiry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Inquiry");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Inquiry",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
