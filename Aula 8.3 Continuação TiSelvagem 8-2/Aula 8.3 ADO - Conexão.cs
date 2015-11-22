using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            MinhaConexao = new SqlConnection(ConfigurationManager.ConnectionString["TISelvagem"].ConnectionString);
            MinhaConexao.Open();
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = MinhaConexao
            };
            cmdComando.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery) {
            var cmdComando = new SqlCommand(strQuery, MinhaConexao);
            return cmdComando.ExecuteReader();
        }

        public void Dispose()
        {
            if (MinhaConexao.State == ConnectionState.Open)
                MinhaConexao.Close();
           
        }
    }
}
