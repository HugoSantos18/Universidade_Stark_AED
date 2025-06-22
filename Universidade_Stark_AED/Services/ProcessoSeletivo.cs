using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade_Stark_AED.Entities;
using Universidade_Stark_AED.IO;

namespace Universidade_Stark_AED.Services
{
    class ProcessoSeletivo
    {
        private Dictionary<int, Curso> todosCursos;
        private List<Candidato> todosCandidatos;

        public ProcessoSeletivo(LeitorArquivo leitor)
        {
            todosCursos = leitor.GetCursos();
            todosCandidatos = leitor.GetCandidatos();
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
            Ordenador ordenador = new Ordenador();

            ordenador.QuickSort(todosCandidatos, 0, todosCandidatos.Count);
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
