using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade_Stark_AED.Entities;
using Universidade_Stark_AED.Interfaces;

namespace Universidade_Stark_AED.Services
{
    class ProcessadorSelecao
    {
        private const int QuantidadeProvas = 3;
        private const string _caminhoArquivo = "C:\\Users\\Pichau\\Desktop\\Entrada.txt";
        private readonly ILeitorArquivo leitorArquivo;

        public ProcessadorSelecao(ILeitorArquivo leitor)
        {
            this.leitorArquivo = leitor;
        }

        public double NotaCorte()
        {
            throw new NotImplementedException();
        }

        public void LerArquivo()
        {
            leitorArquivo.LerArquivo(_caminhoArquivo);
        }
    }
}
