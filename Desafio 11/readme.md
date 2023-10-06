# Reajuste de Slários

*Desafio 11: Reajuste de Slários*

Objetivo: **Calcular o aumento de salário dos colaboradores das Organizações Tabajara:**

*Instruções:*

As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e lhe contraram para desenvolver o programa que calculará os reajustes. <br/>
Faça um programa que recebe o salário de um colaborador e o reajuste segundo o seguinte critério, baseado no salário atual:  <br/>   
    - salários até R$ 280,00 (incluindo) : aumento de 20% <br/>
    - salários entre R$ 280,00 e R$ 700,00 : aumento de 15% <br/>
    - salários entre R$ 700,00 e R$ 1500,00 : aumento de 10% <br/>
    - salários de R$ 1500,00 em diante : aumento de 5% <br/>
 <br/>
Após o aumento ser realizado, informe na tela: <br/>
    - o salário antes do reajuste; <br/>
    - o percentual de aumento aplicado; <br/>
    - o valor do aumento; <br/>
    - o novo salário, após o aumento. <br/>

    
# Explicação do código:

- A primeira linha importa o namespace System, que contém classes e métodos básicos do .NET Framework.
- A classe AumentoDeSalario contém um método Main(), que é o ponto de entrada do programa.
- O método Main() declara uma variável para armazenar o salário do colaborador.
- Em seguida, o método solicita ao usuário que insira o salário do colaborador.
- Depois de receber o salário do colaborador, o método calcula o percentual de aumento.
- O percentual de aumento é calculado de acordo com a faixa salarial do colaborador.
- O método calcula o valor do aumento multiplicando o percentual de aumento pelo salário do colaborador.
- O método calcula o novo salário somando o valor do aumento ao salário do colaborador.
- Por fim, o método exibe a saída, contendo as informações sobre o salário antes do reajuste, o percentual de aumento aplicado, o valor do aumento e o novo salário, após o aumento.<br/>

*Exemplo de saída:*
 <br/>
Insira o salário do colaborador: 1000 <br/>
 <br/>
Salário antes do reajuste: 1000 <br/>
Percentual de aumento aplicado: 10% <br/>
Valor do aumento: 100 <br/>
Novo salário, após o aumento: 1100 <br/>
