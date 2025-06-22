using System;
using Universidade_Stark_AED.Services;
using Universidade_Stark_AED.IO;

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

            ProcessoSeletivo processo = new ProcessoSeletivo(leitor.GetCursos(), leitor.GetCandidatos());
            processo.IniciarProcessoSeletivo();

            EscritorArquivo escritor = new EscritorArquivo();
            escritor.EscreverArquivo(caminhoArquivoEscrita, processo.ObterCursosProcessados());

            Console.WriteLine("Teste, verificar arquivo");
            Console.ReadKey();
        }
    }
}
