using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade_Stark_AED.Entities
{
    public class Candidato
    {
        private string _nomeCandidato;
        private double _notaRedacao;
        private double _notaMatematica;
        private double _notaPortugues;
        private int _codigoPrimeiraOpcao;
        private int _codigoSegundaOpcao;
        private double _media;

        public Candidato(string nomeCandidato, double notaRedacao, double notaMatematica, double notaPortugues,
                                                                   int codigoPrimeiraOpcao, int codigoSegundaOpcao, double media)
        {
            this._nomeCandidato = nomeCandidato;
            this._notaRedacao = notaRedacao;
            this._notaMatematica = notaMatematica;
            this._notaPortugues = notaPortugues;
            this._codigoPrimeiraOpcao = codigoPrimeiraOpcao;
            this._codigoSegundaOpcao = codigoSegundaOpcao;
            this._media = media;
        }


        public string NomeCandidato { get; set; }
        public double NotaRedacao { get; set; }
        public double NotaMatematica { get; set; }
        public double NotaPortugues { get; set; }
        public int CodigoPrimeiraOpcao { get; set; }
        public int CodigoSegundaOpcao { get; set; }
        public double Media { get; set; }
    }
}
