using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    InmuebleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoInmuebleId = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    InmuebleDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InmuebleUbic = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InmuebleCosto = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.InmuebleId);
                });

            migrationBuilder.CreateTable(
                name: "TiposInmuebles",
                columns: table => new
                {
                    TipoInmuebleId = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoInmuebleDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    InmuebleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposInmuebles", x => x.TipoInmuebleId);
                    table.ForeignKey(
                        name: "FK_TiposInmuebles_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId");
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InmuebleId = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    ClienteId = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    CondicionId = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    FormaPagoId = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    VentaDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VentaTotal = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    VentaTotalIva = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    VentaTotalGeneral = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    VentaFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_Ventas_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CleinteDireccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ClienteCorreo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClienteTelefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId");
                });

            migrationBuilder.CreateTable(
                name: "Condiciones",
                columns: table => new
                {
                    CondicionId = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CondicionDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condiciones", x => x.CondicionId);
                    table.ForeignKey(
                        name: "FK_Condiciones_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId");
                });

            migrationBuilder.CreateTable(
                name: "FormasPagos",
                columns: table => new
                {
                    FormaPagoId = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormaPagoDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VentaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagos", x => x.FormaPagoId);
                    table.ForeignKey(
                        name: "FK_FormasPagos_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_VentaId",
                table: "Clientes",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_Condiciones_VentaId",
                table: "Condiciones",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_FormasPagos_VentaId",
                table: "FormasPagos",
                column: "VentaId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposInmuebles_InmuebleId",
                table: "TiposInmuebles",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_InmuebleId",
                table: "Ventas",
                column: "InmuebleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Condiciones");

            migrationBuilder.DropTable(
                name: "FormasPagos");

            migrationBuilder.DropTable(
                name: "TiposInmuebles");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Inmuebles");
        }
    }
}
