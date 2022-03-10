using Microsoft.EntityFrameworkCore.Migrations;

namespace SinavOlusturma.Migrations
{
    public partial class QuestionPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QInWords = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Options1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Options2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Options3 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Options4 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Options15 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Answer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
