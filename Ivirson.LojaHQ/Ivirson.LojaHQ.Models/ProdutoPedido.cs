namespace Ivirson.LojaHQ.Models
{
    public class ProdutoPedido
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
