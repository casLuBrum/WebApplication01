using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    namespace WebApplication1.Models
    {
        public class Ficha
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public bool Ativo { get; set; }
            public int Sexo { get; set; }
            public string Senha { get; set; }
        }
    }
}