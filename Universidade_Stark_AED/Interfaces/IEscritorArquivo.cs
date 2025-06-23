using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade_Stark_AED.Entities;

namespace Universidade_Stark_AED.Interfaces
{
    public interface IEscritorArquivo
    {
        void EscreverArquivo(string caminho, List<Curso> cursos);
    }
}
