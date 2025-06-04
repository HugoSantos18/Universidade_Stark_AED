using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Universidade_Stark_AED.Interfaces;
using Universidade_Stark_AED.Entities;
using Universidade_Stark_AED.DataStructures;

namespace Universidade_Stark_AED.IO
{
    class LeitorArquivo : ILeitorArquivo
    {
        private int quantidadeCursos;
        private int quantidadeCandidatos;
        private Dictionary<int, Curso> todosCursos;
        private List<Candidato> todosCandidatos;


        public int GetQuantidadeCursos()
        {
            return quantidadeCursos;
        }
        public int GetQuantidadeCandidatos()
        {
            return quantidadeCandidatos;
        }
        public Dictionary<int, Curso> GetCursos()
        {
            return todosCursos;
        }


        public List<Candidato> GetCandidatos()
        {
            return todosCandidatos;
        }

        public LeitorArquivo()
        {
            this.quantidadeCursos = 0;
            this.quantidadeCandidatos = 0;
            todosCursos = new Dictionary<int, Curso>();
            todosCandidatos = new List<Candidato>();
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

                if (linha == null)
                    throw new Exception("Arquivo vazio");

                primeiraLinha = linha.Split(';');

                quantidadeCursos = int.Parse(primeiraLinha[0]);
                quantidadeCandidatos = int.Parse(primeiraLinha[1]);


                linha = arquivoLeitura.ReadLine();

                for (int i = 0; i < quantidadeCursos; i++)
                {
                    linha = arquivoLeitura.ReadLine();
                    if (linha == null)
                        throw new Exception("Quantidade de cursos informada não corresponde ao arquivo.");

                    dados = linha.Split(';');

                    int codigoCurso = int.Parse(dados[0]);
                    string nome = dados[1];
                    int vagas = int.Parse(dados[2]);

                    Curso novoCurso = new Curso(codigoCurso, nome, vagas);
                    todosCursos.Add(novoCurso.GetCodigoCurso(), novoCurso);
                }

                for (int i = 0; i < quantidadeCandidatos; i++)
                {
                    linha = arquivoLeitura.ReadLine();
                    if (linha == null)
                        throw new Exception("Quantidade de candidatos informada não corresponde ao arquivo.");

                    dados = linha.Split(';');

                    string nome = dados[0];
                    double notaRedacao = double.Parse(dados[1]);
                    double notaMatematica = double.Parse(dados[2]);
                    double notaLinguagens = double.Parse(dados[3]);
                    int codCursoOp1 = int.Parse(dados[4]);
                    int codCursoOp2 = int.Parse(dados[5]);

                    Candidato novoCandidato = new Candidato(nome, notaRedacao, notaMatematica, notaLinguagens, codCursoOp1, codCursoOp2);
                    todosCandidatos.Add(novoCandidato);
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
