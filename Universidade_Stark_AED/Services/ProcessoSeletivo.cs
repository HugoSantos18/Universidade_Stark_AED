using System;
using System.Collections.Generic;
using System.Linq;
using Universidade_Stark_AED.Entities;

namespace Universidade_Stark_AED.Services
{
    class ProcessoSeletivo
    {
        private Dictionary<int, Curso> todosCursos;
        private List<Candidato> todosCandidatos;
        private Ordenador _ordenador;

        public ProcessoSeletivo(Dictionary<int, Curso> cursos, List<Candidato> candidatos)
        {
            todosCursos = cursos;
            todosCandidatos = candidatos;
            _ordenador = new Ordenador();   
        }

        public void IniciarProcessoSeletivo()
        {
            CalcularMediaCandidatos();
            OrdenarNotaCandidatos();
            AtribuirCandidatosAoCurso();
        }


        private void CalcularMediaCandidatos()
        {
            foreach (Candidato cd in todosCandidatos)
            {
                cd.MediaNotas();
            }
        }
        private void OrdenarNotaCandidatos()
        {
            _ordenador.QuickSort(todosCandidatos, 0, todosCandidatos.Count);
        }

        private void AtribuirCandidatosAoCurso()
        {
            foreach (Candidato cd in todosCandidatos)
            {
                Curso cursoPrimeiraOP = todosCursos[cd.GetCodigoPrimeiraOpcao()];
                Curso cursoSegundaOP = todosCursos[cd.GetCodigoSegundaOpcao()];


                if (cursoPrimeiraOP.TemVaga())
                {
                    cursoPrimeiraOP.AddSelecionado(cd);
                }
                else if (cursoSegundaOP.TemVaga())
                {
                    cursoSegundaOP.AddSelecionado(cd);
                    cursoPrimeiraOP.AddFilaEspera(cd);
                }
                else
                {
                    cursoPrimeiraOP.AddFilaEspera(cd);
                    cursoSegundaOP.AddFilaEspera(cd);
                }
            }
            foreach (Curso c in todosCursos.Values)
            {
                c.NotaCorte();
            }
        }

        public List<Curso> ObterCursosProcessados()
        {
            return todosCursos.Values.ToList();
        }
    }
}
