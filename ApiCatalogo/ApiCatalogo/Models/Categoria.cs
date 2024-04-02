using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Models
{
    [Table("Categorias")]
    public class Categoria
    {
       
        public Categoria()
        {
            Produtos = new Collection<Produto>(); //Aqui estou inicializando a propriedade Produto que é uma coleção de objeto produto(é uma boa pratica)
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required]  // Usar o Required indica que a coluna vai ser not null, isso garante que não é possivél cadastrar no banco de dados uma coluna vazia
        [StringLength(80)] // Aqui estou definindo o máximo de caracteres que pode ser inserido nessa coluna
        public string? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }
        public ICollection<Produto>? Produtos { get; set; } // Aqui estou definindo Que uma Categoria pode ter muitos Produtos

    }
}
