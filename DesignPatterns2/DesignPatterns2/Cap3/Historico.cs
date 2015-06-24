using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap3
{
    public class Historico
    {
        private IList<Contrato> Estados = new List<Contrato>();

        public void Adiciona(Contrato contrato)
        {
            Estados.Add(contrato);
        }

        public Contrato Pega(int indice)
        {
            return Estados[indice];
        }
    }
}
