using Microsoft.EntityFrameworkCore.Migrations;

namespace Galgau_Diana_Proiect.Migrations
{
    public partial class TypeOfCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeOfCarID",
                table: "Car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfCarName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_TypeOfCarID",
                table: "Car",
                column: "TypeOfCarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Type_TypeOfCarID",
                table: "Car",
                column: "TypeOfCarID",
                principalTable: "Type",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Type_TypeOfCarID",
                table: "Car");

            migrationBuilder.DropTable(
                name: "Type");

            migrationBuilder.DropIndex(
                name: "IX_Car_TypeOfCarID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "TypeOfCarID",
                table: "Car");
        }
    }
}
