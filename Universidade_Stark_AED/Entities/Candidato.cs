using System;
using System.Collections.Generic;

namespace Universidade_Stark_AED.Entities
{
    public class Candidato
    {
        private string _nomeCandidato;
        private double _notaRedacao;
        private double _notaMatematica;
        private double _notaLinguagens;
        private int _codigoPrimeiraOpcao;
        private int _codigoSegundaOpcao;
        private const int NumeroProvas = 3;

        public Candidato(string nomeCandidato, double notaRedacao, double notaMatematica, double notaLinguagens,
                                                                   int codigoPrimeiraOpcao, int codigoSegundaOpcao)
        {
            this._nomeCandidato = nomeCandidato;
            this._notaRedacao = notaRedacao;
            this._notaMatematica = notaMatematica;
            this._notaLinguagens = notaLinguagens;
            this._codigoPrimeiraOpcao = codigoPrimeiraOpcao;
            this._codigoSegundaOpcao = codigoSegundaOpcao;
        }

        public string GetNomeCandidato()
        {
            return _nomeCandidato;
        }
        public double GetNotaRedacao()
        {
            return _notaRedacao;
        }
        public double GetNotaMatematica()
        {
            return _notaMatematica;
        }
        public double GetNotaLinguagens()
        {
            return _notaLinguagens;
        }
        public int GetCodigoPrimeiraOpcao()
        {
            return _codigoPrimeiraOpcao;
        }
        public int GetCodigoSegundaOpcao()
        {
            return _codigoSegundaOpcao;
        }

        public double MediaNotas()
        {
            return (_notaRedacao + _notaMatematica + _notaLinguagens) / NumeroProvas;
        }

        public override string ToString()
        {
            return $"{_nomeCandidato} - {MediaNotas():F2}";
        }
    }
}
