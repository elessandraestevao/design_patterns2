using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
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
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Elessandra", TipoContrato.NOVO);
            historico.Adiciona(c);

            c.Avanca();
            historico.Adiciona(c);
            
            c.Avanca();
            historico.Adiciona(c);

            Console.WriteLine(historico.Pega(2).Tipo);
            Console.ReadKey();
        }

        private void testaNotasMusicais()
        {
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>(){
                notas.GetNota("do"),
                notas.GetNota("re"),
                notas.GetNota("mi"),
                notas.GetNota("fa"),
                notas.GetNota("fa"),
                notas.GetNota("fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);
        }

        private void testaConnection(){
            IDbConnection conexao = new ConnectionFactory().GetConnection();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";
        }
    }
}
