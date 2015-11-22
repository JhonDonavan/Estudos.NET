using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Dos
{
    class Contexto:IDisposable
    {

        private readonly SqlConnection MinhaConexao;

        public Contexto()
        {
            MinhaConexao = new SqlConnection(@"data source = NET-INFNET-V4\SQLEXPRESS; integrated security=SSPI; Initial Catalog=TiSelvagem");
            MinhaConexao.Open();
        }

        public void ExecutaComando(string strQuery)
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
