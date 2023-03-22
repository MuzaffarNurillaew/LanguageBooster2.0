using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanguageBooster20.Data.Migrations
{
    public partial class changeInWord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WrittenForm",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WrittenForm",
                table: "Words");
        }
    }
}
