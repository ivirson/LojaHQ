using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ivirson.LojaHQ.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Ativo = true;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
        public bool  Ativo { get; set; }
    }
}
