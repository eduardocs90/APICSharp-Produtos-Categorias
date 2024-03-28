using System.Collections.ObjectModel;

namespace ApiCatalogo.Models
{
    public class Categoria
    {

        public Categoria()
        {
            Produtos = new Collection<Produto>(); //Aqui estou inicializando a propriedade Produto que é uma coleção de objeto produto(éuma boa pratica)
        }

        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? ImagemUrl { get; set; }
        public ICollection<Produto>? Produtos { get; set; } // Aqui estou definindo Que uma Categoria pode ter muitos Produtos

    }
}
