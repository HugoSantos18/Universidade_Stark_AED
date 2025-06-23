using System;
using System.Collections.Generic;
using Universidade_Stark_AED.Entities;
using Universidade_Stark_AED.Services;

namespace Universidade_Stark_AED.DataStructures
{
    class FilaFlexivel
    {
        private Celula primeiro, ultimo;
        private int contador;
        public FilaFlexivel()
        {
            primeiro = ultimo = new Celula();
            contador = 0;
        }
        public int Count()
        {
            return contador;
        }

        public void Inserir(Candidato elemento)
        {
            ultimo.Prox = new Celula(elemento);
            ultimo = ultimo.Prox;
            contador++;
        }

        public Candidato Remover()
        {
            if (primeiro == ultimo)
                throw new InvalidOperationException("Fila vazia!");

            Celula tmp = primeiro.Prox;
            primeiro = primeiro.Prox;

            Candidato removido = primeiro.Elemento;
            tmp.Prox = null;

            contador--;

            return removido;
        }


        public bool Pesquisar(Candidato elemento)
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                if (i.Elemento.Equals(elemento))
                    return true;
            }
            return false;
        }

        public void Exibir()
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento.ToString());
            }
        }
       
        public List<Candidato> ParaLista()
        {
            List<Candidato> lista = new List<Candidato>();

            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                lista.Add(i.Elemento);
            }

            return lista;
        }
    }

}
