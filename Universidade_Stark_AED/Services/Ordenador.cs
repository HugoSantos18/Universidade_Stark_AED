using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade_Stark_AED.Entities;

namespace Universidade_Stark_AED.Services
{
    public class Ordenador
    {
        public void QuickSort(List<Candidato> lista, int esq, int dir)
        {
            int i = esq, j = dir;
            Candidato pivo = lista[(esq + dir) / 2];
            ComparadorDeCandidatos comparador = new ComparadorDeCandidatos();

            while (i <= j)
            {
                while (i <= j && comparador.Compare(lista[i], pivo) > 0)
                    i++;
                while (i <= j && comparador.Compare(lista[j], pivo) < 0)
                    j--;

                if (i <= j)
                {
                    Trocar(lista, i, j);
                    i++;
                    j--;
                }
            }

            if (esq < j)
                QuickSort(lista, esq, j);
            if (i < dir)
                QuickSort(lista, i, dir);
        }

        private void Trocar(List<Candidato> lista, int i, int j)
        {
            Candidato temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }
    }
}
