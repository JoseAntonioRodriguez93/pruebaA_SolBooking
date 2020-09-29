using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaA_SolBooking.Migrations
{
    public partial class Migracioninicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CabeceraHotelItems",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false),
                    Categoria = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true),
                    Destacado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabeceraHotelItems", x => x.Nombre);
                });

            migrationBuilder.CreateTable(
                name: "DetalleHotelItems",
                columns: table => new
                {
                    Nombre = table.Column<string>(nullable: false),
                    Ciudad = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Imagen = table.Column<string>(nullable: true),
                    Caracteristicas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleHotelItems", x => x.Nombre);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CabeceraHotelItems");

            migrationBuilder.DropTable(
                name: "DetalleHotelItems");
        }
    }
}
