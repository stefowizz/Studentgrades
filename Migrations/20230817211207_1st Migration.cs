using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace roundthecode.pdf.Migrations
{
    public partial class _1stMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GrdaeLvl = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Teacher = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Firstgrade = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Secondgrade = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Thirdgrade = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Average = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
