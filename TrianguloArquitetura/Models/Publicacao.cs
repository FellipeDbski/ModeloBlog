using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrianguloArquitetura.Models
{
    public class Publicacao
    {
        public int ID { get; set; }

        public string Titulo { get; set; }

        public string SubTitulo { get; set; }

        public Byte[] Imagem { get; set; }
    }
}