using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaPlus.Migrations
{
    public partial class DeleteLanguageInSocialMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Languages_LanguageId",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_LanguageId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "SocialMedias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_LanguageId",
                table: "SocialMedias",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Languages_LanguageId",
                table: "SocialMedias",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
