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

        public void insert(string nome, string mae, string datanascimento)
        {
            var strQuery = "";
            strQuery += "insert into Alunos (Nome, Mae, DataNascimento)";
            strQuery += string.Format("values('{0}', '{1}','{1}')",
                nome, mae, datanascimento
                );
            using (contexto = new Contexto())
            {
                contexto.ExecutaComando(strQuery);
            }

        }
    }
}
