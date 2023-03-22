using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageBooster20.Data.Migrations
{
    public partial class changeInMeaningMorePropsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "LanguageId",
                table: "Meanings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Abbreviation", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "UZ", new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6650), "Uzbek", null },
                    { 2L, "EN", new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6651), "English", null },
                    { 3L, "GR", new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6652), "German", null },
                    { 4L, "AR", new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6653), "Arabic", null },
                    { 5L, "SP", new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6654), "Spanish", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "NativeLanguageId", "NewLanguageId", "Password", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6746), "Muzaffar", "Nurillayev", 1L, 2L, "0110", null, "muzaffar" },
                    { 2L, new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6748), "Azimjon", "Ochilov", 2L, 2L, "azim", null, "azimochilov" },
                    { 3L, new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6749), "Kamron", "Sayfullayev", 2L, 1L, "kamron", null, "kamron" },
                    { 4L, new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6751), "Safarmurod", "Ashurov", 1L, 2L, "safarmurod", null, "safar" },
                    { 5L, new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6752), "Bekmurod", "Boqiyev", 2L, 4L, "bekmurod", null, "bekmurod" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meanings_LanguageId",
                table: "Meanings",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meanings_Languages_LanguageId",
                table: "Meanings",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meanings_Languages_LanguageId",
                table: "Meanings");

            migrationBuilder.DropIndex(
                name: "IX_Meanings_LanguageId",
                table: "Meanings");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Meanings");
        }
    }
}
