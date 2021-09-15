using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDByAlexanderMartinezForExpressoAmericano.Migrations
{
    public partial class ExpressoAmericanoFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    id_producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_marca = table.Column<int>(type: "int", nullable: false),
                    id_proveedr = table.Column<int>(type: "int", nullable: false),
                    id_zona = table.Column<int>(type: "int", nullable: false),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    descripcion_producto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio = table.Column<float>(type: "real", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    iva = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.id_producto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
