using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanCWebMaster.Migrations
{
    public partial class AddContaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContaId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContaId",
                table: "AspNetUsers");
        }
    }
}
