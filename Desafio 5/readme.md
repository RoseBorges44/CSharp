# Multa da Pesca

*Desafio 5: Multa da Pesca*

Objetivo: **Programa que leia o peso de peixes e verifique se há excesso.
Se houver, gravar o Excesso e o valor da multa que Sr. José
deverá pagar. Caso contrário mostrar os valores com o conteúdo ZERO.**

*Instruções:*

Sr. José, pescador, comprou um microcomputador para controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de
peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. <br/>
Sr. José, precisa que você faça programa que leia o peso de peixes e verifique se há excesso.<br/>
Se houver, gravar o Excesso e o valor da multa que Sr. José deverá pagar. Caso contrário mostrar os valores com o conteúdo ZERO. <br/>
Apresentar as mensagens no console.

# Explicação do código:

- A primeira linha importa o namespace System, que contém classes e métodos básicos do .NET Framework.<br/>
- A classe MultaDePesca contém um método Main(), que é o ponto de entrada do programa.<br/>
- O método Main() declara variáveis para armazenar o peso dos peixes, o peso excedente e o valor da multa.<br/>
- Em seguida, o método solicita ao usuário que insira o peso dos peixes<br/>
- Depois de receber o peso do usuário, o método verifica se o peso é maior que o limite permitido (50 quilos)<br/>
- Se for maior, o método calcula o peso excedente e o valor da multa.<br/>
- Em seguida, o método exibe as mensagens no console.<br/>
- Caso contrário, o método exibe as mensagens de que o peso está dentro do limite permitido.<br/>

*Exemplo de saída:*

Insira o peso dos peixes: 60 <br/>
<br/>
O peso excedente é: 10 <br/>
O valor da multa é: 40 <br/>
