using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap4
{
    public class Divisao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;
        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            return this.esquerda.Avalia() / this.direita.Avalia();
        }
    }
}
