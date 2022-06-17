using Microsoft.EntityFrameworkCore.Migrations;

namespace awamrakeApi.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSlider",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSlider",
                table: "Products");
        }
    }
}
