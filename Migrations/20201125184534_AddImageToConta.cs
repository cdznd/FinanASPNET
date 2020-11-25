using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanCWebMaster.Migrations
{
    public partial class AddImageToConta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Contas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Contas");
        }
    }
}
