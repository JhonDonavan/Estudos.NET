using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula_02___PostGetModel.Models;

namespace Aula_02___PostGetModel.Content
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //teste
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 2,
                Nome = "Jhon Donavan",
                Email = "jhonDonavan@gmail.com"
            };

            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
           
            return View(pessoa);
        }

    }
}
