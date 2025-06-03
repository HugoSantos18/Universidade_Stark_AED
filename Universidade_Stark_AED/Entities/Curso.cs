using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade_Stark_AED.Entities
{
    class Curso
    {
        private int _codigoCurso;
        private string _nomeCurso;
        private int _maxVagas;


        public Curso(int codigoCurso, string nomeCurso, int maxVagas)
        {
            this._codigoCurso = codigoCurso;
            this._nomeCurso = nomeCurso;
            this._maxVagas = maxVagas;
        }

        public int CodigoCurso { get; set; }
        public string NomeCurso { get; set; }
        public int MaxVagas { get; set; }
    }
}
