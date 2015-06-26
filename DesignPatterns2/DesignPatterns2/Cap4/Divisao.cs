﻿using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap4
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda;
        public IExpressao Direita;
        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            return this.Esquerda.Avalia() / this.Direita.Avalia();
        }


        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeDivisao(this);
        }
    }
}
