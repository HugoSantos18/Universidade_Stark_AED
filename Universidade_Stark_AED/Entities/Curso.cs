using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade_Stark_AED.DataStructures;

namespace Universidade_Stark_AED.Entities
{
    public class Curso
    {
        private int _codigoCurso;
        private string _nomeCurso;
        private int _maxVagas;
        private double _notaCorte;
        private double minValue = double.MaxValue;
        private FilaFlexivel<Candidato> filaEspera;
        private List<Candidato> candidatosSelecionados;

        public Curso(int codigoCurso, string nomeCurso, int maxVagas)
        {
            this._codigoCurso = codigoCurso;
            this._nomeCurso = nomeCurso;
            this._maxVagas = maxVagas;
            filaEspera = new FilaFlexivel<Candidato>();
            candidatosSelecionados = new List<Candidato>();
        }

        public int GetCodigoCurso()
        {
            return _codigoCurso;
        }
        public string GetNomeCurso()
        {
            return _nomeCurso;
        }
        public int GetMaxVagas()
        {
            return _maxVagas;
        }

        public bool TemVaga()
        {
            return candidatosSelecionados.Count < _maxVagas;
        }

        public double NotaCorte()
        {
            _notaCorte = 0;
            
            if (candidatosSelecionados.Count > 0)
            {
                foreach (Candidato candidatos in candidatosSelecionados)
                {
                    double media = candidatos.MediaNotas();

                    if (media < minValue)
                    {
                        minValue = media;
                    }
                }
                _notaCorte = minValue;
            }

            return _notaCorte;
        }

        public void AddFilaEspera(Candidato candidato)
        {
            // TO DO
        }

        public void AddSelecionado(Candidato candidato)
        {
            // TO DO
        }
    }
}

