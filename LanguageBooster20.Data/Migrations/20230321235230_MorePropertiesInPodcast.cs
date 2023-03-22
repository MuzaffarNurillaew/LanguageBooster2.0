using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageBooster20.Data.Migrations
{
    public partial class MorePropertiesInPodcast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileLocation",
                table: "Podcasts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OwnerId",
                table: "Podcasts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Podcasts_OwnerId",
                table: "Podcasts",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Podcasts_Users_OwnerId",
                table: "Podcasts",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Podcasts_Users_OwnerId",
                table: "Podcasts");

            migrationBuilder.DropIndex(
                name: "IX_Podcasts_OwnerId",
                table: "Podcasts");

            migrationBuilder.DropColumn(
                name: "FileLocation",
                table: "Podcasts");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Podcasts");
        }
    }
}
