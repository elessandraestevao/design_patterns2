using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap7
{
    public class Pedido
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public Status Status { get; private set; }
        public DateTime DataFinalizacao { get; set; }

        public Pedido(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Status = Status.NOVO;
        }

        public void Paga()
        {
            this.Status = Status.PAGO;
        }

        public void Finaliza()
        {
            this.Status = Status.ENTREGUE;
            this.DataFinalizacao = DateTime.Now;
        }
    }
}
