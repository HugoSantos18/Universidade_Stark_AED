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
    internal class LeitorArquivo : ILeitorArquivo
    {
        private int quantidadeCursos;
        private int quantidadeCandidatos;

        public int GetQuantidadeCursos()
        {
            return quantidadeCursos;
        }
        public int GetQuantidadeCandidatos()
        {
            return quantidadeCandidatos;
        }

        public LeitorArquivo()
        {
            this.quantidadeCursos = 0;
            this.quantidadeCandidatos = 0;
        }

        public void LerArquivo(string caminho)
        {
            string linha;
            string[] dados;
            string[] primeiraLinha;

            try
            {
                StreamReader arquivoLeitura = new StreamReader(caminho);

                linha = arquivoLeitura.ReadLine();

                primeiraLinha = linha.Split(';');
                quantidadeCursos = int.Parse(primeiraLinha[0]);
                quantidadeCandidatos = int.Parse(primeiraLinha[1]);

                while (linha != null)
                {
                    dados = linha.Split(';');

                    for (int i = 1; i <= quantidadeCursos; i++)
                    {

                        Curso curso = new Curso(int.Parse(dados[0]), dados[1], int.Parse(dados[2]));
                        // método para adicionar o curso a estrutura de dados que pertence.
                    }


                    Candidato candidato = new Candidato(dados[0], double.Parse(dados[1]), double.Parse(dados[2]),
                                                        double.Parse(dados[3]), int.Parse(dados[4]), int.Parse(dados[5]));

                    // método para adicionar o candidato a estrutura de dados que pertence.

                    linha = arquivoLeitura.ReadLine();
                }

                arquivoLeitura.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {e.Message}");
            }
        }
    }
}
