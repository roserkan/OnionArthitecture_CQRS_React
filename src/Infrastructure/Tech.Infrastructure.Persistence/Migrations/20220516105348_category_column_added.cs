using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tech.Infrastructure.Persistence.Migrations
{
    public partial class category_column_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                schema: "dbo",
                table: "categories",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                schema: "dbo",
                table: "categories");
        }
    }
}
