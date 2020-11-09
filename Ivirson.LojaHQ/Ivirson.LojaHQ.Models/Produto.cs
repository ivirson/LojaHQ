using System;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Autor { get; set; }
        public string ImagemUrl { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
