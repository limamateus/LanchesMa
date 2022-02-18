using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMa.Migrations
{
    public partial class PopulaCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, DescricaoCurta)" + "VALUES('Normal',' Lanche  normais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, DescricaoCurta)" + "VALUES('Natural','Lanches integrais e natureis' )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
