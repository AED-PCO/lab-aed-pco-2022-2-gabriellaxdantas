# **Laboratório 7:**

## **Exercício 1**
*Descreva quais as operações relevantes.
As operações mais importantes presentes nesse algoritimo são: as comparações feitas para encontrar as palavras IGUAIS e DIFERENTES.

## **Exercício 2**
* Quantos e quais são os casos base/condições de parada para a função?
As condições de parada para essa função são: quando o valor armazenado na variável A  for menor ou igual a 1.

* Explique com suas palavras o que a função calcula.
A função faz um decremento de 2 e um incremento de 5 a variavel A, sendo assim, temos um saldo final de +3 acrescentados a variavel A em todas as chamadas recursivas.

* Represente a pilha de execução da função
(6-2)+5 = 9 -> entrará em um loop pois a função sempre fará um incremento de +3 a cada chamada recursiva.

## **Exercício 3**
* Descreva quais são as operações relevantes
As operações relevantes presentes nesse algoritimo são: as trocas das posições através dos laços de repetição presentes.

## **Exercício 4**
* O especialista escolheu um bom algoritimo? Justifique.
Não. Como os números de um CPF as vezes são bem parecidos, é interessante que se faça a utilização de um algoritimo de ordenação que não faça tantas comparações como o insertion sort (que faz a comparação com todos os anteriores a posição selecionada).

* Qual algortimo de ordenação você utilizaria?
Nesse caso, eu optaria por utilizar o Merge Sort, já que não seria necessário fazer tantas comparações com o insertion, e, utilizando o método de "dividir para conquistar" teremos no pior caso, um custo bem menor O(n log n).

* Descreva quais as operações relevantes.
No caso do Merge Sort as operações mais relevantes são as divisões do vetor e as comparações para realizar a ordenação.

* Demonstre a viabilidade da sua solução (Aqui utilizando um algoritimo que gere CPFs e uma entrada de 50.000).
A viabilidade da minha solução está representada na imagem abaixo:

Criei um metodo que ficou responsável pela criação de 50.000 CPFs simulados para a utilização no teste de viabilidade da minha solução para o problema passado. Com a quantidade de CPFs passada, começamos a organização desses dados tendo como técnica o Merge Sort. Também foi criado um metodo separado para a aplicação da técnica. Após a ordenação feita, foi printado na tela o vetor.



## **Exercício 5**
* Analise e indique o que será retornado pela função caso os parâmetros possuam os seguintes dados: v = {10, 5, 7, 15, 22, 9, 30} e a=6:
A função não entrará no 1o if, pois a é diferente de 1, sendo assim, ela entrará no else. Entrando nesse else, é criada uma variavel X que recebe a chamada recursiva de funcao(a-1, v). Sendo assim X receberá o valor de 5. Após ter esse valor atribuido, passa para o próximo if que faz a verficação se X é maior do que o número presente na posição a-1 do vetor (nesse caso, posição 5, ou seja, o valor 9). Sendo essa verificação FALSA, pois 5 é menor que 9, ele sai desse if e vai para o próximo else retornando o v[a-1] que agora é o valor 22.