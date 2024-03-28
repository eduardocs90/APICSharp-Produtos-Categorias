namespace ApiCatalogo.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }   
        public decimal Preco {  get; set; } 
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        public int CategoriaId { get; set; } // Aqui vai mapear para coluna CategoriaID que vai ser criada na tabela Produto
        public Categoria? Categoria { get; set; } // Aqui é uma propriedade de navegação que define que produto ta mapeado para uma categoria
    }
}
