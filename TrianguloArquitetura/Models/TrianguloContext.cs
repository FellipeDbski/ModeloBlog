using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrianguloArquitetura.Models
{
    public class TrianguloContext :DbContext
    {

        public TrianguloContext() : base("BaseTesteTriangulo")
        {
            
        }


        public DbSet<Publicacao> Publicacao { get; set; }
        public DbSet<SubImagens> SubImagens { get; set; }
    }
}