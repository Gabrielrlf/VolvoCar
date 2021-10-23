using Microsoft.EntityFrameworkCore.Migrations;

namespace VolvoCar.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Truck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModelName = table.Column<string>(type: "TEXT", maxLength: 2, nullable: true),
                    YearModel = table.Column<int>(type: "INTEGER", nullable: false),
                    YearFabrication = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Truck",
                columns: new[] { "Id", "ModelName", "YearFabrication", "YearModel" },
                values: new object[] { 1, "FH", 2021, 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Truck");
        }
    }
}
