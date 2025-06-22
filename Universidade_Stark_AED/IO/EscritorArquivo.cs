using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Universidade_Stark_AED.Interfaces;
using Universidade_Stark_AED.Entities;

namespace Universidade_Stark_AED.IO
{
    internal class EscritorArquivo : IEscritorArquivo
    {
        public void EscreverArquivo(string caminho, List<Curso> cursos)
        {
            using (StreamWriter arquivoEscrita = new StreamWriter(caminho))
            {
                foreach (Curso curso in cursos)
                {
                    arquivoEscrita.WriteLine($"{curso.GetNomeCurso()} {curso.NotaCorte():F2}");

                    arquivoEscrita.WriteLine("Selecionados");
                    foreach (Candidato candidato in curso.CandidatosSelecionadosOrdenados())
                    {
                        arquivoEscrita.WriteLine(candidato.ToString());
                    }

                    arquivoEscrita.WriteLine("Fila de Espera");
                    foreach (Candidato candidato in curso.CandidatosEsperaOrdenados())
                    {
                        arquivoEscrita.WriteLine(candidato.ToString());
                    }

                    arquivoEscrita.WriteLine();
                }
            }
        }
    }
}
