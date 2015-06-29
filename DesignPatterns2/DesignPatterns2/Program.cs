using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
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
            
        }

        private void testaCommand()
        {
            Pedido pedido1 = new Pedido("Elessandra", 500.0);
            Pedido pedido2 = new Pedido("Aparecida", 300.0);
            FilaDeTrabalho fila = new FilaDeTrabalho();
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));
            fila.Processa();
        }

        private void testaBridge()
        {
            IMensagem mensagem = new MensagemCliente("Elessandra");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
        }

        private void testaPreFixaVisitor()
        {
            Multiplicacao multiplicacao = new Multiplicacao((new Subtracao(new Numero(50), new Numero(45))), new Numero(30));
            IVisitor visitor2 = new PreFixaVisitor();
            visitor2.ImprimeMultiplicacao(multiplicacao);
            Console.WriteLine();
            Console.WriteLine(multiplicacao.Avalia());
        }

        private void testaImpressoraVisitor()
        {
            RaizQuadrada raizQuadrada = new RaizQuadrada(new Numero(81));
            IVisitor visitor1 = new ImpressoraVisitor();
            visitor1.ImprimeRaizQuadrada(raizQuadrada);
            Console.WriteLine();
            Console.WriteLine(raizQuadrada.Avalia());
            Console.WriteLine();

            Multiplicacao multiplicacao = new Multiplicacao((new Subtracao(new Numero(50), new Numero(45))), new Numero(30));
            IVisitor visitor2 = new ImpressoraVisitor();
            visitor2.ImprimeMultiplicacao(multiplicacao);
            Console.WriteLine();
            Console.WriteLine(multiplicacao.Avalia());

            Console.WriteLine();

            Divisao divisao = new Divisao((new Subtracao(new Numero(50), new Numero(50))), new Numero(30));
            IVisitor visitor3 = new ImpressoraVisitor();
            visitor3.ImprimeDivisao(divisao);
            Console.WriteLine();
            Console.WriteLine(divisao.Avalia());
        }

        private void testaInterpreter(){
            IExpressao soma = new Soma(new Numero(10), new Numero(15));
            Console.WriteLine(soma.Avalia());

            IExpressao subtracao = new Subtracao(new Numero(10), new Numero(15));
            Console.WriteLine(subtracao.Avalia());
        }

        private void testaHistorico()
        {
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Elessandra", TipoContrato.NOVO);
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(historico.Pega(0).Tipo);
            Console.WriteLine(historico.Pega(1).Tipo);
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
