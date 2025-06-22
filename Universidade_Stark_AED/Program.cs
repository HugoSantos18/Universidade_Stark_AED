using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Universidade_Stark_AED.Services;
using Universidade_Stark_AED.Interfaces;
using Universidade_Stark_AED.IO;
using Universidade_Stark_AED.DataStructures;
using Universidade_Stark_AED.Entities;

namespace Universidade_Stark_AED
{
    class Program
    {
        static FilaFlexivel<Candidato> filaEspera;
        static List<Candidato> listaSelecionados;

        const string caminhoArquivo = "C:\\Users\\Pichau\\Desktop\\Entrada.txt";

        /* TO DO:
        - fazer método para atribuir um selecionado ao seu respectivo curso
        - fazer método para atribuir um candidato a fila de espera
        - fazer método para definir a nota de corte de um curso após todos serem selecionados já
        */
        
        static void ExibirSelecionados()
        {
            foreach (Candidato selecionado in listaSelecionados)
            {
                Console.WriteLine(selecionado.ToString());
            }
        }

        static void Main(string[] args)
        {
            // teste
            LeitorArquivo leitor = new LeitorArquivo();

            leitor.LerArquivo(caminhoArquivo);

            ExibirSelecionados();

            filaEspera.Exibir();

            Console.ReadKey();
        }
    }
}
