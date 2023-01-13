﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.Migrations
{
    /// <inheritdoc />
    public partial class tercera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Condiciones_CondicionId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_FormasPagos_FormaPagoId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Inmuebles_InmuebleId",
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
                name: "IX_Ventas_InmuebleId",
                table: "Ventas");
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
                name: "IX_Ventas_InmuebleId",
                table: "Ventas",
                column: "InmuebleId",
                unique: true,
                filter: "[InmuebleId] IS NOT NULL");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Inmuebles_InmuebleId",
                table: "Ventas",
                column: "InmuebleId",
                principalTable: "Inmuebles",
                principalColumn: "InmuebleId");
        }
    }
}