using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanCWebMaster.Migrations
{
    public partial class AddIsProfitField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isProfit",
                table: "Lancamentos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isProfit",
                table: "Lancamentos");
        }
    }
}
