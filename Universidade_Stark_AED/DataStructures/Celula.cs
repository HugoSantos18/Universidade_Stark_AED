using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade_Stark_AED.DataStructures
{
    class Celula<T>
    {
        private T elemento;
        private Celula<T> prox;

        public Celula(T elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }

        public Celula()
        {
            this.elemento = default(T);
            this.prox = null;
        }

        public Celula<T> Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public T Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }
    }
}
