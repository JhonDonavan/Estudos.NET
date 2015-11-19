using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;

namespace Aula_03___ExemploValidacao.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string Observacao { get; set; }

        public int Idade { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }
    }
}