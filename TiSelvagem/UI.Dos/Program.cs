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
            var contexto = new Contexto();

            Console.Write("Digite o nome do Aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome da mae do aluno: ");
            string mae = Console.ReadLine();

            Console.Write("Digite a data de nascimento do aluno: ");
            string data = Console.ReadLine();

            new AlunoAplicacao().insert(nome, mae, data);

      
            string strQuerySelect = "Select * from Alunos";


            SqlDataReader dados = contexto.ExecutaComandoComRetorno(strQuerySelect); 

            while (dados.Read())
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Mae{2}, DataNascimento:{3}", dados["AlunoId"], dados["Nome"], dados["Mae"], dados["DataNascimento"]);
            }
            
        }
    }
}
