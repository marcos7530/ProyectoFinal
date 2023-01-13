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
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CleinteDireccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ClienteCorreo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClienteTelefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Condiciones",
                columns: table => new
                {
                    CondicionId = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CondicionDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condiciones", x => x.CondicionId);
                });

            migrationBuilder.CreateTable(
                name: "FormasPagos",
                columns: table => new
                {
                    FormaPagoId = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormaPagoDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagos", x => x.FormaPagoId);
                });

            migrationBuilder.CreateTable(
                name: "TiposInmuebles",
                columns: table => new
                {
                    TipoInmuebleId = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoInmuebleDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposInmuebles", x => x.TipoInmuebleId);
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    InmuebleId = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoInmuebleId = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    InmuebleDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InmuebleUbic = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InmuebleCosto = table.Column<int>(type: "int", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.InmuebleId);
                    table.ForeignKey(
                        name: "FK_Inmuebles_TiposInmuebles_TipoInmuebleId",
                        column: x => x.TipoInmuebleId,
                        principalTable: "TiposInmuebles",
                        principalColumn: "TipoInmuebleId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Ventas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Condiciones_CondicionId",
                        column: x => x.CondicionId,
                        principalTable: "Condiciones",
                        principalColumn: "CondicionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_FormasPagos_FormaPagoId",
                        column: x => x.FormaPagoId,
                        principalTable: "FormasPagos",
                        principalColumn: "FormaPagoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inmuebles_TipoInmuebleId",
                table: "Inmuebles",
                column: "TipoInmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_CondicionId",
                table: "Ventas",
                column: "CondicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_FormaPagoId",
                table: "Ventas",
                column: "FormaPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_InmuebleId",
                table: "Ventas",
                column: "InmuebleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Condiciones");

            migrationBuilder.DropTable(
                name: "FormasPagos");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "TiposInmuebles");
        }
    }
}
