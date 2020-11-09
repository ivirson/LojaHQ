using System;
using System.Collections.Generic;

namespace Ivirson.LojaHQ.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<ProdutoPedido> Produtos { get; set; }
        public DateTime DataPedido { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
