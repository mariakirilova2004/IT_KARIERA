using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace SchoolNew.Migrations
{
    public partial class Last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewSchool",
                columns: table => new
                {
                    SchoolPK = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewSchool", x => x.SchoolPK);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Discipline = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    TestPK = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Age = table.Column<int>(nullable: false),
                    SchoolPK = table.Column<int>(nullable: true),
                    city_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.TestPK);
                    table.ForeignKey(
                        name: "FK_Students_NewSchool_SchoolPK",
                        column: x => x.SchoolPK,
                        principalTable: "NewSchool",
                        principalColumn: "SchoolPK",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Cities_city_id",
                        column: x => x.city_id,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsTeachers",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsTeachers", x => new { x.StudentId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_StudentsTeachers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "TestPK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NewSchool",
                columns: new[] { "SchoolPK", "Name" },
                values: new object[,]
                {
                    { 1, "Vasil Levski" },
                    { 2, "Vasil Levski" },
                    { 3, "Vasil Levski" },
                    { 4, "Vasil Levski" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "TestPK", "Age", "Name", "SchoolPK", "city_id" },
                values: new object[] { 1, 12, "Koko", 2, null });

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolPK",
                table: "Students",
                column: "SchoolPK");

            migrationBuilder.CreateIndex(
                name: "IX_Students_city_id",
                table: "Students",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsTeachers_TeacherId",
                table: "StudentsTeachers",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsTeachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "NewSchool");
        }
    }
}
