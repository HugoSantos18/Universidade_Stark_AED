using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade_Stark_AED.Entities
{
    class Candidato
    {
        private string _nomeCandidato;
        private double _notaRedacao;
        private double _notaMatematica;
        private double _notaPortugues;
        private int _codigoPrimeiraOpcao;
        private int _codigoSegundaOpcao;


        public Candidato(string nomeCandidato, double notaRedacao, double notaMatematica, double notaPortugues,
                                                                   int codigoPrimeiraOpcao, int codigoSegundaOpcao)
        {
            this._nomeCandidato = nomeCandidato;
            this._notaRedacao = notaRedacao;
            this._notaMatematica = notaMatematica;
            this._notaPortugues = notaPortugues;
            this._codigoPrimeiraOpcao = codigoPrimeiraOpcao;
            this._codigoSegundaOpcao = codigoSegundaOpcao;
        }


        public string NomeCandidato { get; set; }
        public double NotaRedacao { get; set; }
        public double NotaMatematica { get; set; }
        public double NotaPortugues { get; set; }
        public int CodigoPrimeiraOpcao { get; set; }
        public int CodigoSegundaOpcao { get; set; }
    }
}
