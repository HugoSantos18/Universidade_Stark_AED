using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Universidade_Stark_AED.Services;
using Universidade_Stark_AED.Interfaces;
using Universidade_Stark_AED.IO;

namespace Universidade_Stark_AED
{
    class Program
    {
        static void Main(string[] args)
        {
            ILeitorArquivo leitor = new LeitorArquivo();
            ProcessadorSelecao processoSeletivo = new ProcessadorSelecao(leitor);
            processoSeletivo.LerArquivo();


            Console.ReadKey();
        }
    }
}
