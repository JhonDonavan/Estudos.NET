using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula_04___RotasMVC.Models;

namespace Aula_04___RotasMVC.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IEnumerable<Noticia> todasNoticias;

        public HomeController()
        {
            todasNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data); 
        }

        public ActionResult Index()
        {
            var ultimasNoticias = todasNoticias.Take(3);
            var todasCategorias = todasNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasCategorias;
;           return View(ultimasNoticias);
        }

        public ActionResult TodasNoticias()
        {
            return View(todasNoticias);
        }

        public ActionResult MostrarNoticia(int noticiaId, string categoria, string titulo)
        {
            return View(todasNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaespecifica = todasNoticias.Where(x => x.Categoria == categoria);
            ViewBag.Categoria = categoria;
            return View(categoriaespecifica);

        }
    }
}
