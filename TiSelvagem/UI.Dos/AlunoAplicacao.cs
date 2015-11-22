using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Dos
{
    public class AlunoAplicacao
    {
        private Contexto contexto;

        public void insert(Aluno aluno)
        {
            var strQuery = "";
            strQuery += "insert into Alunos (Nome, Mae, DataNascimento)";
            strQuery += string.Format("values('{0}', '{1}','{2}')",
              aluno.Nome, aluno.Mae, aluno.DataNascimento
                );
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }

        }

        public void alterar(Aluno aluno)
        {
            var strQuery = "";
            strQuery += "Update Aluno set";
            strQuery += string.Format("Nome = '{0}', ", aluno.Nome);
            strQuery += string.Format("Mae =' {0}', ", aluno.Mae);
            strQuery += string.Format("DataNascimento = '{0}' ", aluno.DataNascimento);
            strQuery += string.Format("Where AlunoId = '{0}' ", aluno.Id);
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }
        }
    }
}
