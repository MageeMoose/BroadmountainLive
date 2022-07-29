using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BroadmountainLive.Server.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NavImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AltText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsExt = table.Column<bool>(type: "bit", nullable: false),
                    IsSign = table.Column<bool>(type: "bit", nullable: false),
                    IsTopNav = table.Column<bool>(type: "bit", nullable: false),
                    Delay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavImages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NavImages",
                columns: new[] { "Id", "AltText", "Delay", "ImgUrl", "IsExt", "IsSign", "IsTopNav", "PathName", "Text" },
                values: new object[,]
                {
                    { 1, "", 0, "BroadmountainLive/Client/wwwroot/images/About me.png", false, false, false, "/aboutme", "" },
                    { 2, "", 0, "BroadmountainLive/Client/wwwroot/images/Cv.png", false, false, false, "/cv", "" },
                    { 3, "", 0, "BroadmountainLive/Client/wwwroot/images/Projects.png", false, false, false, "/project", "" },
                    { 4, "", 0, "BroadmountainLive/Client/wwwroot/images/Skills.png", false, false, false, "/skillsandcerts", "" },
                    { 5, "", 0, "BroadmountainLive/Client/wwwroot/images/GitHub.png", true, false, false, "https://github.com/MageeMoose", "" },
                    { 6, "", 0, "BroadmountainLive/Client/wwwroot/images/Linkedin.png", true, false, false, "https://www.linkedin.com/in/magnus-bredberg-b3684121/", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NavImages");
        }
    }
}
