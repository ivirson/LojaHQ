using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ivirson.LojaHQ.Data;
using Ivirson.LojaHQ.Models;

namespace Ivirson.LojaHQ.API.Controllers
{
    [Route("api/revistas")]
    [ApiController]
    public class RevistasController : ControllerBase
    {
        private readonly DataContext _context;

        public RevistasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/revistas
        /// <summary>
        /// Serviço que retorna a lista de Revistas cadastradas no banco de dados e com status "ativo"
        /// </summary>
        /// <returns>
        /// Retorna a lista de Revistas
        /// </returns>
        [HttpGet]
        public IActionResult GetRevistas()
        {
            var revistas = _context.Revistas.Where(r => r.Ativa).ToList();
            return Ok(revistas);
        }

        // GET: api/revistas/5
        /// <summary>
        /// Método que retorna, em detalhes, uma Revista que esteja ativa no banco de dados
        /// </summary>
        /// <param name="id">Identificadoor da revista a ser detalhada</param>
        /// <returns>
        /// Retorna uma Revista, caso encontre. 
        /// Caso contrário, retorna código 404 (Not Found)
        /// </returns>
        [HttpGet("{id}")]
        public IActionResult GetRevista(int id)
        {
            var revista = _context.Revistas.Find(id);

            if (revista == null || !revista.Ativa)
            {
                return NotFound();
            }

            return Ok(revista);
        }

        // PUT: api/revistas/5
        /// <summary>
        /// Método de edição de uma Revista previamente existente
        /// </summary>
        /// <param name="id">Identificadoor da revista a ter suas informações alteradas</param>
        /// <param name="revista">Objeto com as alterações</param>
        /// <returns>
        /// Retorna apenas o código de sucesso, em caso de sucesso.
        /// Caso o Id enviado seja diferente do Id da revista enviada, retorna BadRequest.
        /// Caso o Id enviado não corresponda a um Revista válida, retorna código 404 (Not Found) 
        /// </returns>
        [HttpPut("{id}")]
        public IActionResult PutRevista(int id, Revista revista)
        {
            if (id != revista.Id)
            {
                return BadRequest();
            }

            _context.Entry(revista).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RevistaExists(id))
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

        // POST: api/revistas
        /// <summary>
        /// Metodo de criação de uma nova Revista no banco de dados
        /// </summary>
        /// <param name="revista">Revista a ser adicionada</param>
        /// <returns>
        /// Retorna a revista adicionada
        /// </returns>
        [HttpPost]
        public IActionResult PostRevista(Revista revista)
        {
            _context.Revistas.Add(revista);
            _context.SaveChanges();

            return CreatedAtAction("GetRevista", new { id = revista.Id }, revista);
        }

        // DELETE: api/revistas/5
        /// <summary>
        /// Método de exclusão lógica de uma Revista previamente cadastrada no banco de dados
        /// </summary>
        /// <param name="id">Identificadoor da revista a ser excluída</param>
        /// <returns>
        /// Retorna apenas o código de sucesso, em caso de sucesso.
        /// Caso o Id enviado não corresponda a um Revista válida, retorna código 404 (Not Found) 
        /// </returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteRevista(int id)
        {
            var revista = _context.Revistas.Find(id);
            if (revista == null)
            {
                return NotFound();
            }

            revista.Ativa = false;
            _context.Entry(revista).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        private bool RevistaExists(int id)
        {
            return _context.Revistas.Any(e => e.Id == id);
        }
    }
}
