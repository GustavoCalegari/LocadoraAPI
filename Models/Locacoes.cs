using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraAPI.Models
{
    public class Locacoes
    {
        public int idLocacao { get; set; }
        public DateTime dataLocacao { get; set; }
        public DateTime dataDevolucao { get; set; }

        public Locacoes(int idLocacao, DateTime dataLocacao, DateTime dataDevolucao)
        {
            this.idLocacao = idLocacao;
            this.dataLocacao = dataLocacao;
            this.dataDevolucao = dataDevolucao;
        }
    }
}