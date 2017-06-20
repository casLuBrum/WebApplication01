using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.WebApplication1.Models;

namespace WebApplication1.Models
{
    public class FichaService
    {
        static List<Ficha> fichas = new List<Ficha>();
        public FichaService()
        {
            for (int i = 0; i < 30; i++)
            {
                Ficha ficha = new Ficha();
                ficha.Id = i;
                ficha.Ativo = true;
                ficha.DataNascimento = DateTime.Now;
                ficha.Nome = "Nome " + i;
                ficha.Sexo = i % 2;
                fichas.Add(ficha);
            }
        }

        public List<Ficha> ObterTodasFichas()
        {
            return fichas;
        }

        public Ficha ObterFicha(int id)
        {
            return fichas[id];
        }

        public void alterar(Ficha ficha)
        {
            fichas[ficha.Id] = ficha;
        }
    }
}