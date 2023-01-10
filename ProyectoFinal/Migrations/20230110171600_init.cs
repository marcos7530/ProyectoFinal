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
                    idcliente = table.Column<int>(name: "id_cliente", type: "int", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrecliente = table.Column<string>(name: "nombre_cliente", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dircliente = table.Column<string>(name: "dir_cliente", type: "nvarchar(255)", maxLength: 255, nullable: false),
                    correocliente = table.Column<string>(name: "correo_cliente", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefonocliente = table.Column<string>(name: "telefono_cliente", type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.idcliente);
                });

            migrationBuilder.CreateTable(
                name: "Condiciones",
                columns: table => new
                {
                    idcondicion = table.Column<int>(name: "id_condicion", type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desccondicion = table.Column<string>(name: "desc_condicion", type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condiciones", x => x.idcondicion);
                });

            migrationBuilder.CreateTable(
                name: "FormasPagos",
                columns: table => new
                {
                    idformapago = table.Column<int>(name: "id_forma_pago", type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desformapago = table.Column<string>(name: "des_forma_pago", type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormasPagos", x => x.idformapago);
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    idinmueble = table.Column<int>(name: "id_inmueble", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idtipoinmueble = table.Column<int>(name: "id_tipo_inmueble", type: "int", maxLength: 2, nullable: false),
                    descinmueble = table.Column<string>(name: "desc_inmueble", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ubicinmueble = table.Column<string>(name: "ubic_inmueble", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    costoinmueble = table.Column<int>(name: "costo_inmueble", type: "int", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.idinmueble);
                });

            migrationBuilder.CreateTable(
                name: "TiposInmuebles",
                columns: table => new
                {
                    idtipoinmueble = table.Column<int>(name: "id_tipo_inmueble", type: "int", maxLength: 2, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desctipoinmueble = table.Column<string>(name: "desc_tipo_inmueble", type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposInmuebles", x => x.idtipoinmueble);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    idventa = table.Column<int>(name: "id_venta", type: "int", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idinmueble = table.Column<int>(name: "id_inmueble", type: "int", maxLength: 2, nullable: false),
                    idcliente = table.Column<int>(name: "id_cliente", type: "int", maxLength: 2, nullable: false),
                    idcondicion = table.Column<int>(name: "id_condicion", type: "int", maxLength: 2, nullable: false),
                    idformapago = table.Column<int>(name: "id_forma_pago", type: "int", maxLength: 2, nullable: false),
                    descventa = table.Column<string>(name: "desc_venta", type: "nvarchar(255)", maxLength: 255, nullable: true),
                    totalventa = table.Column<int>(name: "total_venta", type: "int", maxLength: 10, nullable: false),
                    totaliva = table.Column<int>(name: "total_iva", type: "int", maxLength: 8, nullable: false),
                    totalgeneral = table.Column<int>(name: "total_general", type: "int", maxLength: 12, nullable: false),
                    fechaventa = table.Column<DateTime>(name: "fecha_venta", type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.idventa);
                });
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
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "TiposInmuebles");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
