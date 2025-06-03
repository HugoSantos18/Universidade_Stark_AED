# Universidade Stark - Trabalho Prático de Algoritmos e Estruturas de Dados

Este projeto foi desenvolvido pelos seguintes integrantes: 

- **Hugo dos Santos**
- **Lucas Almeida**
- **Vitor Abreu**

## Descrição do problema

Para realização do trabalho de Algoritmos e Estruturas de Dados para edificar e solidificar conehcimentos vistos na disciplina, o seguinte desafio:

Foi contratado para desenvolver um programa para gerenciar o processo seletivo da Universidade Stark. Nesta universidade, os cursos possuem números restritos de vagas, mas possuem infinitas posições
na fila de espera. Para seleção dos candidatos deve ser utilizada a média simples das notas da Redação, prova de Matemática e prova de Linguagens (somar as três notas e dividir por três). Caso ocorra 
empate de notas entre alunos, o critério de desempate será a nota da redação. 
(OBS: Não terão outros critérios de desempate). 
Assim vamos considerar que dois alunos com a mesma média sempre terão as notas da Redação diferentes). Na Universidade Stark, cada candidato deve selecionar duas opções de curso. 
O candidato selecionado em sua primeira opção não deverá ser colocado em nenhuma fila de espera. O candidato selecionado para sua segunda opção deverá ser colocado na fila de espera da primeira opção. 
Um candidato que não for selecionado para nenhuma de suas opções deverá ser colocado na fila de espera de ambos os cursos (opções 1 e 2). Se um candidato for selecionado para suas duas
opções de curso, ele deve ser incluído apenas na lista de candidatos selecionados da sua primeira opção de curso (isto é, deve liberar a vaga da segunda opção).


## Requisitos: 

O programa deverá ler informações de um arquivo de entrada e ao final do processamento deverá criar um arquivo texto
contendo as seguintes informações:

- Nome e nota de corte de cada curso (A nota de corte de cada curso é a menor nota média dos selecionados para o curso).

- Lista de candidatos selecionados (nome e nota média de cada candidato), em ordem decrescente de nota média.

- Fila de espera (nome e nota média de cada candidato), em ordem decrescente de nota média.

**Arquivo de Entrada (entrada.txt)**

A primeira linha do arquivo de entrada conterá dois inteiros N e M:
N : número de cursos
M: número de candidatos
As N linhas seguintes terão as seguintes informações sobre os N cursos, separadas por ponto e vírgula: código do curso
(inteiro), nome do curso (string) e quantidade de vagas disponíveis no curso (int).

Após as informações dos cursos, as próximas M linhas terão as informações dos M candidatos. Cada linha terá as
seguintes informações separadas por ponto e vírgula: nome do candidato (string), nota obtida pelo candidato na redação
(double), nota obtida pelo candidato na prova de matemática (double), nota obtida pelo candidato na prova de linguagens
(double), código da primeira opção de curso (int) e o código da segunda opção de curso.
Arquivo de Saída (saida.txt)

Para cada curso, na mesma ordem de entrada, deverá ser escrito em uma mesma linha o nome do curso e a nota de corte, separados por um espaço.
Na próxima linha deverá ser escrita somente a String “Selecionados”. Em seguida deverão ser escritas Si linhas contendo
o nome do candidato e sua nota média, com duas casas decimais. 
Os candidatos deverão estar em ordem decrescente de nota média, seguindo o critério de desempate especificado anteriormente.

Por fim, deverá ser escrita a String “Fila de Espera”. Em seguida, Ei linhas contendo os nomes e as notas médias dos
candidatos, com duas casas decimais, que estão na fila de espera do curso.
 Os candidatos deverão estar em ordem decrescente de nota média, seguindo o critério de desempate.

## Detalhes do Projeto

O projeto será feito como um aplicativo de console, utilizando .NET, seguindo os princípios SOLID e boas práticas de Programação Orientada a Objetos (POO).

