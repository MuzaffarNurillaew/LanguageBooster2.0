using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageBooster20.Data.Migrations
{
    public partial class newPropsInFavouriteItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouritePodcasts_Languages_LanguageId",
                table: "FavouritePodcasts");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "FavouritePodcasts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FavouritePodcasts_LanguageId",
                table: "FavouritePodcasts",
                newName: "IX_FavouritePodcasts_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouritePodcasts_Users_UserId",
                table: "FavouritePodcasts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouritePodcasts_Users_UserId",
                table: "FavouritePodcasts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "FavouritePodcasts",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_FavouritePodcasts_UserId",
                table: "FavouritePodcasts",
                newName: "IX_FavouritePodcasts_LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouritePodcasts_Languages_LanguageId",
                table: "FavouritePodcasts",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
