using System.Linq;
using Ivirson.LojaHQ.Data;
using Ivirson.LojaHQ.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ivirson.LojaHQ.API.Controllers
{
    [Route("api/vitrine")]
    [ApiController]
    public class VitrineController : ControllerBase
    {
        private readonly DataContext _context;

        public VitrineController(DataContext context)
        {
            _context = context;
        }

        // GET: api/vitrine
        /// <summary>
        /// Serviço que retorna a lista de Produtos disponíveis para compra"
        /// </summary>
        /// <returns>
        /// Retorna a lista de Produtos
        /// </returns>
        [HttpGet]
        public IActionResult GetProdutos()
        {
            var produtos = _context.Produtos.Where(p => p.Ativo && p.Quantidade > 0).ToList();
            return Ok(produtos);
        }

        // GET: api/vitrine/5
        /// <summary>
        /// Método que retorna, em detalhes, um Produto que esteja disponível para compra
        /// </summary>
        /// <param name="id">Identificador da produto a ser detalhado</param>
        /// <returns>
        /// Retorna um Produto, caso encontre. 
        /// Caso contrário, retorna código 404 (Not Found)
        /// </returns>
        [HttpGet("{id}")]
        public IActionResult GetProduto(int id)
        {
            var produto = _context.Produtos.Find(id);

            if (produto == null || !produto.Ativo || produto.Quantidade == 0)
            {
                return NotFound();
            }

            return Ok(produto);
        }
        //POST: api/vitrine/pedido
        /// <summary>
        /// Método que salva o pedido, atualizando o estoque dos produtos envolvidos
        /// </summary>
        /// <param name="pedido">Objeto que contém as informações do pedido, bem como os seus itens</param>
        /// <returns></returns>
        [HttpPost("pedido")]
        [Authorize]
        public IActionResult RealizarPedido(Pedido pedido)
        {
            foreach (var item in pedido.Produtos)
            {
                var produto = _context.Produtos.Find(item.ProdutoId);
                produto.Quantidade -= item.Quantidade;
                _context.Entry(produto).State = EntityState.Modified;
            }
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return Ok();
        }
    }
}
