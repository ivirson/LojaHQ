using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ivirson.LojaHQ.Data;
using Ivirson.LojaHQ.Models;
using Microsoft.AspNetCore.Authorization;

namespace Ivirson.LojaHQ.API.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProdutosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/produtos
        /// <summary>
        /// Serviço que retorna a lista de Produtos cadastrados no banco de dados e com status "ativo"
        /// </summary>
        /// <returns>
        /// Retorna a lista de Produtos
        /// </returns>
        [HttpGet]
        [Authorize]
        public IActionResult GetProdutos()
        {
            var produtos = _context.Produtos.Where(p => p.Ativo).ToList();
            return Ok(produtos);
        }

        // GET: api/produtos/5
        /// <summary>
        /// Método que retorna, em detalhes, um Produto que esteja ativo no banco de dados
        /// </summary>
        /// <param name="id">Identificador da produto a ser detalhado</param>
        /// <returns>
        /// Retorna um Produto, caso encontre. 
        /// Caso contrário, retorna código 404 (Not Found)
        /// </returns>
        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetProduto(int id)
        {
            var produto = _context.Produtos.Find(id);

            if (produto == null || !produto.Ativo)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        // PUT: api/produtos/5
        /// <summary>
        /// Método de edição de um Produto previamente existente
        /// </summary>
        /// <param name="id">Identificador da produto a ter suas informações alteradas</param>
        /// <param name="produto">Objeto com as alterações</param>
        /// <returns>
        /// Retorna apenas o código de sucesso, em caso de sucesso.
        /// Caso o Id enviado seja diferente do Id do produto enviado, retorna BadRequest.
        /// Caso o Id enviado não corresponda a um Produto válido, retorna código 404 (Not Found) 
        /// </returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult PutProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/produtos
        /// <summary>
        /// Metodo de criação de um novo Produto no banco de dados
        /// </summary>
        /// <param name="produto">Produto a ser adicionado</param>
        /// <returns>
        /// Retorna o produto adicionado
        /// </returns>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult PostProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
        }

        // DELETE: api/produtos/5
        /// <summary>
        /// Método de exclusão lógica de um Produto previamente cadastrado no banco de dados
        /// </summary>
        /// <param name="id">Identificadoor do produto a ser excluído</param>
        /// <returns>
        /// Retorna apenas o código de sucesso, em caso de sucesso.
        /// Caso o Id enviado não corresponda a um Produto válido, retorna código 404 (Not Found) 
        /// </returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteProduto(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }

            produto.Ativo = false;
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
