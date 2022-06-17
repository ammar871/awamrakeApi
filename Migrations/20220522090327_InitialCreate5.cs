using Microsoft.EntityFrameworkCore.Migrations;

namespace awamrakeApi.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "OfferPrice",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferPrice",
                table: "Products");
        }
    }
}
