using ApiCatalogo.DataContext;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetProdutos()
        {
            var produtos = _context.Produtos.ToList();
            if (produtos is null)
            {
                return NotFound("Produto não encontrado!");
            }

            return produtos;
        }
        [HttpGet("{id:int}", Name = "ObterProduto")] // , Name = "ObterProduto" / essa rota aqui foi estabelecida para capturar o método Post
        public ActionResult<Produto> GetProdutoByID(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado!");
            }
            return produto;
        }
        [HttpPost]
        public ActionResult PostProduto(Produto produto)
        {

            if (produto == null)
            {
                return BadRequest("");
            }

            _context.Produtos.Add(produto); // Na função de Post aqui, primeiro usamos o .Add no_context.Produtos para postar na memoria
            _context.SaveChanges(); // E Usamos o .SaveChanges() para salvar no banco de dados 


            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto); // Aqui no metodo de Post é retonaro O 201 (CreatedAtRouteResult) e aciona a rota do produto creado (Essa rota támbem é estabelecida no método GetProdutoById), adiciona o Id no produto e por fim retorna  produto
        }
        [HttpPut("{id:int}")]
        public ActionResult PutProduto(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeleteProduto(int id)


        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado");

            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return Ok(produto);
        }
    }
}
