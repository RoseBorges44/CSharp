# Questão 4

4 - Ao executar o código a seguir será exibido qual valor no terminal? Justifique sua resposta.

*Int32 numero; <br/>
numero = Convert.ToInt16(!(21 > 21)); <br/>
Console.WriteLine(numero);''* <br/>

**A) -1;** <br/>
B) 0; <br/>
C) 1; <br/>
D) 21; <br/>
E) Irá dar erro <br/>
 <br/>
 
***Explicação:*** <br/>
*O código declara a variável numero, do tipo **Int32** e faz uma série de operações, com seu resultado sendo atribuído à variável número. 
Primeiro, o código verifica se 21 > 21, o que é falso porque 21 não é maior que 21.* <br/> Depois há uma negação, que inverte o resultado falso de 21 > 21.* <br/>
O resultado encontrado anteriormente (o inverso de false, true) é convertido para Int16, e como true convertido para Int é 1, o **resultado imprime 1 na tela.**
