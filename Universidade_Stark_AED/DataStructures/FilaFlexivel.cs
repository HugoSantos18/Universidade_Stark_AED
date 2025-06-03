using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade_Stark_AED.DataStructures
{
    class FilaFlexivel<T>
    {
        private Celula<T> primeiro, ultimo;

        public FilaFlexivel()
        {
            primeiro = ultimo = new Celula<T>(default);
        }

        public void Inserir(T elemento)
        {
            ultimo.Prox = new Celula<T>(elemento);
            ultimo = ultimo.Prox;
        }

        public T Remover()
        {
            if (primeiro == ultimo)
                throw new InvalidOperationException("Fila vazia!");

            Celula<T> tmp = primeiro.Prox;
            primeiro = primeiro.Prox;

            T removido = primeiro.Elemento;
            tmp.Prox = null;

            return removido;
        }

        public bool Pesquisar(T elemento)
        {
            for (Celula<T> i = primeiro.Prox; i != null; i = i.Prox)
            {
                if (i.Elemento.Equals(elemento))
                    return true;
            }
            return false;
        }

        public void Exibir()
        {
            for (Celula<T> i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento);
            }
        }
    }

}
