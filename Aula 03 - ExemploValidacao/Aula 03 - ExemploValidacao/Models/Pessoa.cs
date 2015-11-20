using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Profile;
using Newtonsoft.Json;

namespace Aula_03___ExemploValidacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength(50,MinimumLength = 5, ErrorMessage= "A observacao deve ter entre 5 e 50 caracter")]
        public string Observacao { get; set; }

        [Required(ErrorMessage = "A senha deve ser preenchida!")]
        [Range(18,50, ErrorMessage="A idade da pessoa teve ser entre 18 e 50 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "A senha deve ser preenchida!")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})$", ErrorMessage="O email não é válido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage="Login deve ter entre 5 e 15 caracteres")]
        [Required(ErrorMessage="O login deve ser preenchido")]
        [Remote("LoginUnico", "Pessoa", ErrorMessage="Usuario já existente")]
        public string Login { get; set; }

        [Required(ErrorMessage="A senha deve ser preenchida!")]
        [StringLength(15, MinimumLength = 7, ErrorMessage = "A senha deve possui entre 7 e 15 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "A senha deve ser preenchida!")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage= "Senhas nao conferem")]
        [StringLength(15, MinimumLength = 7, ErrorMessage = "A senha deve possui entre 7 e 15 caracteres")]
        public string ConfirmarSenha { get; set; }
    }
}