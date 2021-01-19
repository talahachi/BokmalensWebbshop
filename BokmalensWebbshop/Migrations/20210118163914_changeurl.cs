using Microsoft.EntityFrameworkCore.Migrations;

namespace BokmalensWebbshop.Migrations
{
    public partial class changeurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://images-na.ssl-images-amazon.com/images/I/81Hs+IrRmwL.jpg", "https://images-na.ssl-images-amazon.com/images/I/81Hs+IrRmwL.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "BokmalensWebbshop/wwwroot/images/1984.jpg", "BokmalensWebbshop/wwwroot/images/1984.jpg" });
        }
    }
}
