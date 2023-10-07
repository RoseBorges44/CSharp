# Soma de Vetores

*Desafio 12: Soma de Vetores*

Objetivo: **Construir dois vetores A e B de 10 elementos e criar um vetor C**

*Instruções:*

Faça um algoritmo que construa dois vetores A e B de 10 elementos e,a partir deles, crie um vetor C, composto pela somados elementos, sendo: <br/>   

C[1] = A[1] + B[9], <br/>   C[2] = A[2] + B[9], <br/>   C[3] = A[3] + B[8], <br/>   etc. <br/>

    
# Explicação do código:

- A primeira linha importa o namespace System, que contém classes e métodos básicos do .NET Framework.
- A classe SomaDeVetores  contém um método Main(), que é o ponto de entrada do programa.
- O método Main() declara três variáveis para armazenar os valores dos vetores A, B e C.
- Em seguida, o método inicializa os vetores A e B com valores de 0 a 9.
- Depois de inicializar os vetores A e B, o método calcula os elementos do vetor C.
- O método calcula os elementos do vetor C somando o elemento i do vetor A com o elemento 9 - i do vetor B.
- Por fim, o método exibe os vetores A, B e C.

  
*Exemplo de saída:*

 <br/>
Vetor A:
0
1
2
3
4
5
6
7
8
9' <br/>
 <br/>
Vetor B:
9
8
7
6
5
4
3
2
1
0<br/>
 <br/>
Vetor C:
9
17
25
33
41
49
57
65
73
81
