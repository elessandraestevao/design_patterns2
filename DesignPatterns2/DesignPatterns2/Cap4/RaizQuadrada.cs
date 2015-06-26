using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap4
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Expressao;
        public RaizQuadrada(IExpressao expressao)
        {
            this.Expressao = expressao;
        }

        public int Avalia()
        {
            return (int) Math.Sqrt(this.Expressao.Avalia());
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeRaizQuadrada(this);
        }
    }
}
