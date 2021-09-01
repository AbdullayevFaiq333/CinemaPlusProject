using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaPlus.Migrations
{
    public partial class AddBuyedToTheSeat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Buyed",
                table: "Seats",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Buyed",
                table: "Seats");
        }
    }
}
