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
            if (lista == null || lista.Count == 0)
                return;

            if (esq < 0 || dir >= lista.Count || esq >= dir)
                return;

            int i = esq, j = dir;
            double pivoNota = lista[(esq + dir) / 2].MediaNotas();

            while (i <= j)
            {
                while (i <= dir && lista[i].MediaNotas() > pivoNota)
                    i++;

                while (j >= esq && lista[j].MediaNotas() < pivoNota)
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
