using Microsoft.EntityFrameworkCore.Migrations;

namespace thecloudbilltest.Migrations.Login
{
    public partial class Registr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Register",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Register");
        }
    }
}
