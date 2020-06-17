using Microsoft.EntityFrameworkCore.Migrations;

namespace thecloudbilltest.Migrations
{
    public partial class TexInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TexInvoices",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", nullable: false),
                    Location = table.Column<string>(type: "varchar(100)", nullable: false),
                    City = table.Column<string>(type: "varchar(100)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Qty = table.Column<string>(type: "varchar(10)", nullable: false),
                    Price = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TexInvoices", x => x.InvoiceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TexInvoices");
        }
    }
}
