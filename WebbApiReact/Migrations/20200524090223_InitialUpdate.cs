using Microsoft.EntityFrameworkCore.Migrations;

namespace WebbApiReact.Migrations
{
    public partial class InitialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbCandidate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(16)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Age = table.Column<int>(nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(3)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbCandidate", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbCandidate");
        }
    }
}
