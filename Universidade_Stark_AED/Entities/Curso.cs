using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Universidade_Stark_AED.DataStructures;
using Universidade_Stark_AED.Services;

namespace Universidade_Stark_AED.Entities
{
    public class Curso
    {
        private int _codigoCurso;
        private string _nomeCurso;
        private int _maxVagas;
        private double _notaCorte;
        private double minValue = double.MaxValue;
        private FilaFlexivel filaEspera;
        private List<Candidato> candidatosSelecionados;
        private Ordenador algoritmoOrdenador = new Ordenador();

        public Curso(int codigoCurso, string nomeCurso, int maxVagas)
        {
            this._codigoCurso = codigoCurso;
            this._nomeCurso = nomeCurso;
            this._maxVagas = maxVagas;
            filaEspera = new FilaFlexivel();
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

        public List<Candidato> CandidatosSelecionadosOrdenados()
        {
            algoritmoOrdenador.QuickSort(candidatosSelecionados, 0, candidatosSelecionados.Count - 1);

            return candidatosSelecionados;
        }

        public List<Candidato> CandidatosEsperaOrdenados()
        {
            List<Candidato> lista = filaEspera.ParaLista();
            algoritmoOrdenador.QuickSort(lista, 0, lista.Count - 1);
            
            return lista;
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
            if (TemVaga())
            {
                filaEspera.Inserir(candidato);
            }
        }

        public void AddSelecionado(Candidato candidato)
        {
            if (TemVaga())
            {
                candidatosSelecionados.Add(candidato);
            }
        }

        public void RemoverFilaEspera(Candidato candidato)
        {
            if (filaEspera.Pesquisar(candidato))
                filaEspera.Remover();
        }

        public override string ToString()
        {
            return $"{_nomeCurso} " + $"{_notaCorte:F2}";
        }
    }
}

