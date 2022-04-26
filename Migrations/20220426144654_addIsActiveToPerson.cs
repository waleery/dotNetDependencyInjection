using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetDependencyInjection.Migrations
{
    public partial class addIsActiveToPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Person",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Person");
        }
    }
}
