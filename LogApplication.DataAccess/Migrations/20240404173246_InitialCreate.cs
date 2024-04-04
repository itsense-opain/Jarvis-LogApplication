using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogApplication.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Seguridad");

            migrationBuilder.CreateTable(
                name: "tbl_log_aplicacion",
                schema: "Seguridad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    funcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    componente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    detalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_entrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_creacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_log_aplicacion", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_log_aplicacion",
                schema: "Seguridad");
        }
    }
}
