using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Access.Migrations
{
    public partial class ChangeTopicModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Office",
                table: "HackdayTopics",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Office",
                table: "HackdayTopics");
        }
    }
}
