# Média das Notas

*Desafio 8:  Média das Notas*

Objetivo: **Calcular a nota do exame final**

*Instruções:*

Um aluno realizou três provas de uma determinada disciplina. <br/>Levando em consideração o
critério apresentado a seguir, faça um programa que mostre se ele ficou para exame final,
e caso positivo, que nota o aluno precisará obter para passar de ano.<br/>
<br/>
"Média = (Prova 1 + Prova 2 + Prova 3) / 3"<br/>
<br/>
A média deve ser igual ou maior que 7,0. Caso o aluno não consiga, a nova média deve ser:<br/>
<br/>
"Final = (Média + Exame) / 2"<br/>
<br/>
A média final para a aprovação deve ser igual ou maior que 5,0.<br/>

<br/>

# Explicação do código:

- A primeira linha importa o namespace System, que contém classes e métodos básicos do .NET Framework.<br/>
- A classe MediaFinal  contém um método Main(), que é o ponto de entrada do programa.<br/>
- O método Main() declara variáveis para armazenar os valores de entrada do aluno.<br/>
- Em seguida, o método solicita ao usuário que insira as notas das provas.<br/>
- Depois de receber os valores do usuário, o método calcula a média das provas.<br/>
- Em seguida, o método verifica se o aluno passou de ano.<br/>
- Se o aluno passou de ano, o método exibe uma mensagem de aprovação.<br/>
- Caso contrário, o método calcula a nota do exame e a média final.<br/>
- Por fim, o método exibe uma mensagem de que o aluno precisará fazer o exame e a nota necessária para aprovação.<br/>

<br/>

*Exemplo de saída:*

Insira a nota da prova 1: 6<br/>
Insira a nota da prova 2: 6<br/>
Insira a nota da prova 3: 6<br/>
<br/>
O aluno ficou para exame final.<br/>
Nota necessária para aprovação: 6,5<br/>
<br/>
