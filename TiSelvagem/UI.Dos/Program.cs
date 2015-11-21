using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection minhaconexao = new SqlConnection(@"data source = NET-INFNET-V4\SQLEXPRESS; integrated security=SSPI; Initial Catalog=TiSelvagem");
            minhaconexao.Open();

            

            /*string strQueryUpdate = "Update alunos  set nome = 'Jhon D. M de Olveira' where AlunoId =1 ";
            SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, minhaconexao);
            cmdComandoUpdate.ExecuteNonQuery();*/

            /*string strQueryDelete = "Delete from Alunos where AlunoId =2 ";
            SqlCommand cmdComandoDelete = new SqlCommand(strQueryDelete, minhaconexao);
            cmdComandoDelete.ExecuteNonQuery();*/

            Console.Write("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome da mae do aluno: ");
            string mae = Console.ReadLine();

            Console.Write("Digite a data de nascimento do aluno: ");
            string data = Console.ReadLine();

            string strQueryInsert =string.Format("insert into Alunos (Nome, Mae, DataNascimento) values ('{0}','{1}', '{2}')",nome, mae, data);
            SqlCommand cmdComandoInsert = new SqlCommand(strQueryInsert, minhaconexao);
            cmdComandoInsert.ExecuteNonQuery();


            string strQuerySelect = "Select * from Alunos";
            SqlCommand cmdComandoSelect = new SqlCommand(strQuerySelect,minhaconexao);
            SqlDataReader dados = cmdComandoSelect.ExecuteReader();

            while (dados.Read())
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Mae{2}, DataNascimento:{3}", dados["AlunoId"], dados["Nome"], dados["Mae"], dados["DataNascimento"]);
            }
            
        }
    }
}
