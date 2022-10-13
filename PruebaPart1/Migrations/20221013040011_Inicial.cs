using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaPart1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona_cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    primerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    segundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    primerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    segundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona_cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona_cliente");
        }
    }
}
