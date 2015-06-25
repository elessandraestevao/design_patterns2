using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns2.Cap3;

namespace DesignPatterns2
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

        public void Avanca()
        {
            if (this.Tipo == TipoContrato.NOVO) this.Tipo = TipoContrato.EM_ANDAMENTO;
            else if (this.Tipo == TipoContrato.EM_ANDAMENTO) this.Tipo = TipoContrato.ACERTADO;
            else if (this.Tipo == TipoContrato.ACERTADO) this.Tipo = TipoContrato.CONCLUIDO;
        }

        public Contrato SalvaEstado()
        {
            return new Contrato(this.Data, this.Cliente, this.Tipo);
        }
    }
}
