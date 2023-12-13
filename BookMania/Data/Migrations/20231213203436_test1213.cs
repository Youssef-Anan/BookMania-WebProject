using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookMania.Data.Migrations
{
    /// <inheritdoc />
    public partial class test1213 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Book");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "test",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
