using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrianguloArquitetura.Models
{
    public class SubImagens
    {
        public int ID { get; set; }

        public Publicacao Publicacao { get; set; }

        public int PublicacaoID { get; set; }

        public string Descriacao { get; set; }
    }
}