using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    /// <inheritdoc />
    public partial class quinta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inmuebles_TiposInmuebles_TipoInmuebleId",
                table: "Inmuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Condiciones_CondicionId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_FormasPagos_FormaPagoId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_CondicionId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_FormaPagoId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Inmuebles_TipoInmuebleId",
                table: "Inmuebles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_Inmuebles_TipoInmuebleId",
                table: "Inmuebles",
                column: "TipoInmuebleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inmuebles_TiposInmuebles_TipoInmuebleId",
                table: "Inmuebles",
                column: "TipoInmuebleId",
                principalTable: "TiposInmuebles",
                principalColumn: "TipoInmuebleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Condiciones_CondicionId",
                table: "Ventas",
                column: "CondicionId",
                principalTable: "Condiciones",
                principalColumn: "CondicionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_FormasPagos_FormaPagoId",
                table: "Ventas",
                column: "FormaPagoId",
                principalTable: "FormasPagos",
                principalColumn: "FormaPagoId");
        }
    }
}
