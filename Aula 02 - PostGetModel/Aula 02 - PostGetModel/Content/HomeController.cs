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

        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Jhon Donavan",
                Email = "jhonDonavan@gmail.com"
            };

            

            return View(pessoa);
        }

    }
}
