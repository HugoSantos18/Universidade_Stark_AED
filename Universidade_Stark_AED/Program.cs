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
        const string caminhoArquivoLeitura = "C:\\Users\\Pichau\\Desktop\\Entrada.txt";
        const string caminhoArquivoEscrita = "C:\\Users\\Pichau\\Desktop\\Saida.txt";
       
        static void Main(string[] args)
        {
            LeitorArquivo leitor = new LeitorArquivo();
            leitor.LerArquivo(caminhoArquivoLeitura);

            ProcessoSeletivo processo = new ProcessoSeletivo(leitor);
            processo.IniciarProcessoSeletivo();

            EscritorArquivo escritor = new EscritorArquivo();
            escritor.EscreverArquivo(caminhoArquivoEscrita, processo.ObterCursosProcessados());

            Console.WriteLine("Teste, verificar arquivo");
            Console.ReadKey();
        }
    }
}
