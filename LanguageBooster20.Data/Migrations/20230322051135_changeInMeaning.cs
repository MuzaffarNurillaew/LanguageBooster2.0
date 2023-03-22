using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageBooster20.Data.Migrations
{
    public partial class changeInMeaning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteWords_Languages_LanguageId",
                table: "FavouriteWords");

            migrationBuilder.DropForeignKey(
                name: "FK_Meanings_Languages_LanguageId",
                table: "Meanings");

            migrationBuilder.DropForeignKey(
                name: "FK_Meanings_Words_WordId",
                table: "Meanings");

            migrationBuilder.DropIndex(
                name: "IX_Meanings_LanguageId",
                table: "Meanings");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Meanings");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "FavouriteWords",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_FavouriteWords_LanguageId",
                table: "FavouriteWords",
                newName: "IX_FavouriteWords_UserId");

            migrationBuilder.AlterColumn<long>(
                name: "WordId",
                table: "Meanings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteWords_Users_UserId",
                table: "FavouriteWords",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Meanings_Words_WordId",
                table: "Meanings",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteWords_Users_UserId",
                table: "FavouriteWords");

            migrationBuilder.DropForeignKey(
                name: "FK_Meanings_Words_WordId",
                table: "Meanings");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "FavouriteWords",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_FavouriteWords_UserId",
                table: "FavouriteWords",
                newName: "IX_FavouriteWords_LanguageId");

            migrationBuilder.AlterColumn<long>(
                name: "WordId",
                table: "Meanings",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "LanguageId",
                table: "Meanings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Meanings_LanguageId",
                table: "Meanings",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteWords_Languages_LanguageId",
                table: "FavouriteWords",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Meanings_Languages_LanguageId",
                table: "Meanings",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Meanings_Words_WordId",
                table: "Meanings",
                column: "WordId",
                principalTable: "Words",
                principalColumn: "Id");
        }
    }
}
