using Microsoft.EntityFrameworkCore.Migrations;

namespace PNBS.Migrations
{
    public partial class Seeding_Grade_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "GradeName" },
                values: new object[,]
                {
                    { 1, "C0321G1" },
                    { 2, "C0621H1" },
                    { 3, "C0621H2" },
                    { 4, "C0721K1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 4);
        }
    }
}
