using Microsoft.EntityFrameworkCore.Migrations;

namespace BokmalensWebbshop.Migrations
{
    public partial class AddSomething : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "BokmalensWebbshop/wwwroot/images/1984.jpg", "BokmalensWebbshop/wwwroot/images/1984.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/images/1984.jpg", "~/images/1984.jpg" });
        }
    }
}
