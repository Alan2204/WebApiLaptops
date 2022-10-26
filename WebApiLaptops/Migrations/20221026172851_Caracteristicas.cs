using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiLaptops.Migrations
{
    public partial class Caracteristicas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caracteristicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procesador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grafica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<int>(type: "int", nullable: false),
                    TipoMemoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memoria = table.Column<int>(type: "int", nullable: false),
                    SistemaOperativo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resolucion = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caracteristicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caracteristicas_Laptops_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Laptops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caracteristicas_MarcaId",
                table: "Caracteristicas",
                column: "MarcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caracteristicas");
        }
    }
}
