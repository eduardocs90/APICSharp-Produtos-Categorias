using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required] //faz a coluna não ser nula, ou seja nao pode cadastrar esse campo vazio no banco de dados 
        [StringLength(80)] //Coloca um maximo de caractere que pode ser cadastrado no banco
        public string? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string? Descricao { get; set; }
        [Required]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Preco {  get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        public int CategoriaId { get; set; } // Aqui vai mapear para coluna CategoriaID que vai ser criada na tabela Produto (Essa é a chave estrangeira que fica no muitos para 1)
        public Categoria? Categoria { get; set; } // Aqui é uma propriedade de navegação que define que produto ta mapeado para uma categoria
    }
}
