using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginAndBoard.Migrations
{
    public partial class UserAccMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JoinUser",
                columns: table => new
                {
                    UserID = table.Column<string>(nullable: false),
                    UserPW = table.Column<string>(nullable: false),
                    UserEmail = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinUser", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "LoginUser",
                columns: table => new
                {
                    UserNo = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserID = table.Column<string>(nullable: false),
                    UserPW = table.Column<string>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginUser", x => x.UserNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinUser");

            migrationBuilder.DropTable(
                name: "LoginUser");
        }
    }
}
