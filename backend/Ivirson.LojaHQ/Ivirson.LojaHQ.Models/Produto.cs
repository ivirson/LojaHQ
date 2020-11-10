using System;

namespace Ivirson.LojaHQ.Models
{
    public class Produto
    {
        public Produto()
        {
            Ativo = true;
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Autor { get; set; }
        public string ImagemUrl { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
