using Microsoft.EntityFrameworkCore.Migrations;

namespace BokmalensWebbshop.Migrations
{
    public partial class qqqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Author",
                value: "George Orwell");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Author",
                value: null);
        }
    }
}
