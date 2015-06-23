using DesignPatterns2.Cap1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";
        }
    }
}
