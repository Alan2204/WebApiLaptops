using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiLaptops.Migrations
{
    public partial class LapCaracteristicas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caracteristicas_Laptops_MarcaId",
                table: "Caracteristicas");

            migrationBuilder.DropIndex(
                name: "IX_Caracteristicas_MarcaId",
                table: "Caracteristicas");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Caracteristicas");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Laptops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TipoMemoria",
                table: "Caracteristicas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Procesador",
                table: "Caracteristicas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Caracteristicas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Grafica",
                table: "Caracteristicas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LapCaracteristicas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LapId = table.Column<int>(type: "int", nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: false),
                    LaptopId = table.Column<int>(type: "int", nullable: true),
                    CaracteristicasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapCaracteristicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LapCaracteristicas_Caracteristicas_CaracteristicasId",
                        column: x => x.CaracteristicasId,
                        principalTable: "Caracteristicas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LapCaracteristicas_Laptops_LaptopId",
                        column: x => x.LaptopId,
                        principalTable: "Laptops",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LapCaracteristicas_CaracteristicasId",
                table: "LapCaracteristicas",
                column: "CaracteristicasId");

            migrationBuilder.CreateIndex(
                name: "IX_LapCaracteristicas_LaptopId",
                table: "LapCaracteristicas",
                column: "LaptopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LapCaracteristicas");

            migrationBuilder.AlterColumn<string>(
                name: "Marca",
                table: "Laptops",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TipoMemoria",
                table: "Caracteristicas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Procesador",
                table: "Caracteristicas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Caracteristicas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Grafica",
                table: "Caracteristicas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Caracteristicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Caracteristicas_MarcaId",
                table: "Caracteristicas",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caracteristicas_Laptops_MarcaId",
                table: "Caracteristicas",
                column: "MarcaId",
                principalTable: "Laptops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
