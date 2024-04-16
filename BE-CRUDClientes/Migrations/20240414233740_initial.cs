using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_CRUDClientes.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identificacion = table.Column<int>(type: "int", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Maneja = table.Column<bool>(type: "bit", nullable: false),
                    Lentes = table.Column<bool>(type: "bit", nullable: false),
                    Diabetico = table.Column<bool>(type: "bit", nullable: false),
                    OtraEnfermedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
