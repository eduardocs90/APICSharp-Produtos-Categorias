using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Coca-Cola Diet', 'Refrigerante de Cola 350 ml', 5.45, 'cocacola.jpg', 50, GETDATE(), 1)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Brioche', 'Pão com Queijo e Presunto', 8.50, 'sanduiche.png', 10, GETDATE(), 2)");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) VALUES ('Pudim 100 mg', 'Pudim de leite condesado 100mg', 6.75, 'pudim.png', 20, GETDATE(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
