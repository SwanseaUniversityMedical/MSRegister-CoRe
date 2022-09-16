using Microsoft.EntityFrameworkCore.Migrations;

namespace MSRegister_CoRe.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Root",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Device",
                table: "Root",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Root");

            migrationBuilder.DropColumn(
                name: "Device",
                table: "Root");
        }
    }
}
