using System;
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

        private readonly LeitorArquivo leitor;

        public ProcessoSeletivo()
        {
            todosCursos = leitor.GetCursos();
            todosCandidatos = leitor.GetCandidatos();
        }

        // TO DO restante dos métodos e lógica do fluxo do processo seletivo.
    }
}
