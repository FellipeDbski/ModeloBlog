using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrianguloArquitetura.DAO;
using TrianguloArquitetura.Models;

namespace TrianguloArquitetura.Controllers
{
    public class PublicacaoController : Controller
    {
        // GET: Postagem
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovaPublicacao(Publicacao publicacao, HttpPostedFileBase arquivo)
        {
            PublicacaoRepositorio DAO = new PublicacaoRepositorio();    
            var post = arquivo;
            var file = new FileInfo(post.FileName);
            using (var reader = new BinaryReader(post.InputStream))
            {
                publicacao.Imagem = reader.ReadBytes(post.ContentLength);
            }
            DAO.Adiciona(publicacao);
            return RedirectToAction("Index", "Home");
        }
    }
}