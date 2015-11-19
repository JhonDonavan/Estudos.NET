using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula_03___ExemploValidacao.Models;

namespace Aula_03___ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {
       
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

    }
}
