using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidade_Stark_AED.Entities;

namespace Universidade_Stark_AED.Services
{
    public class ComparadorDeCandidatos : IComparer<Candidato>
    {
        public int Compare(Candidato x, Candidato y)
        {
            double mediaX = x.Media;
            double mediaY = y.Media;

            if (mediaX != mediaY)
                return mediaY.CompareTo(mediaX);
            else
                return y.NotaRedacao.CompareTo(x.NotaRedacao);
        }
    }
}
