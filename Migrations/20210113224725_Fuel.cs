using Microsoft.EntityFrameworkCore.Migrations;

namespace Galgau_Diana_Proiect.Migrations
{
    public partial class Fuel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuelID",
                table: "Car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fuel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuel", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_FuelID",
                table: "Car",
                column: "FuelID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Fuel_FuelID",
                table: "Car",
                column: "FuelID",
                principalTable: "Fuel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Fuel_FuelID",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Fuel");

            migrationBuilder.DropIndex(
                name: "IX_Car_FuelID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "FuelID",
                table: "Car");
        }
    }
}
