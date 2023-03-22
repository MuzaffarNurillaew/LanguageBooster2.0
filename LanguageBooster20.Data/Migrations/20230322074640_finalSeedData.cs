using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageBooster20.Data.Migrations
{
    public partial class finalSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "ChosenLanguageId", "CreatedAt", "LanguageId", "UpdatedAt", "WrittenForm" },
                values: new object[] { 1L, 2L, new DateTime(2023, 3, 22, 7, 46, 40, 63, DateTimeKind.Utc).AddTicks(7052), null, null, "Afraid" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 22, 7, 3, 55, 575, DateTimeKind.Utc).AddTicks(6752));
        }
    }
}
