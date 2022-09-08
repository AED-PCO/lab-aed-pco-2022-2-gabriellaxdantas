# **Exercício 1** 
___
##### Foi proposto pelo exercício a criação de uma algoritimo que pudesse mostrar todos os números que tem quadrados perfeitos de 1000 até 9999.

##### Para resolver esse problema, teriamos que encontrar os números de 1000 até 9999 que atendessem as condições do quadrado perfeito. Assim, primeiro teriamos que dividir esse algarismo em 2 partes, para isso, utilizei a divisão e o resto de divisão. Armazenei esses valores em duas variaveis e testei se o quociente multiplicado pelo resto resultariam no prórpio número. Caso eles sejam iguais, o número é printado na tela.
### Resolução:
[(https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/main/relatorio/Laboratorio%201/img/Lab1-Ex1.png)](https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/f0cf8351337e4b915237993d04b05b04a725aea8/relatorio/Laboratorio%201/img/Lab1-Ex1.png)

___
# **Exercício 2** 
___
##### Foi criado um algoritimo para identificar se um número é ou não primo, e um para encontrar os números perfeitos de 1 a 1000

##### Para a primeira parte do exercício eu fiz um algoritimo que testava se o número informado pelo usuário era primo, utilizando um laço de repetição e testando se o número era divisivel pelo indice. Caso fosse, era adicionado mais 1 na variavel auxiliar div. SSe a variavel resultasse 2, o número era printado na tela informando ao usuário que era primo.

##### A segunda parte do exercício pedia que encontrassemos os números perfeitos de 1 até 1000. Para isso, criei um laço de repetição onde K ia de 1 até 1000. Dentro desse primeiro laço de repetição, eu defini a metade do número, para posteriormente utiliza-la nos testes de número perfeito, e zerei a variavel soma para que ela sempre voltasse a ser 0 após o segundo laço de repetição. O segundo laço de repetição foi criado para encontrar os divisores menores que o número.  O laço ia de 1 até a metade do número, já que não é possível haver um divisor maior do que a metade de qualquer número. Essa repetição testava os divisores, somava os possíveis divisores e armazenava na variavel auxiliar soma. Se o resultado de soma fosse igual ao K, o número era printado na tela como sendo um algarismo perfeito.

### Resolução:
[!(https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/main/relatorio/Laboratorio%201/img/Lab1-Ex2.png)](https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/f0cf8351337e4b915237993d04b05b04a725aea8/relatorio/Laboratorio%201/img/Lab1-Ex2.png)

___
# **Exercício 3** 
___
##### Nessa questão foi feito um algoritimo para criar dois vetores resultantes a partir de outros dois. Um onde era exibido os valores comuns entre os dois primeiros vetores. O outro mostrava os alementos de A que não estavam em B. 

##### Primeiro foi feito um laço de repetição para armazenar os valores nos vetores A e B. Depois foi feito um for dentro de outro, para assim testar se os valores de Vetor A [j] eram iguais aos valores do vetor B [i]. Se esses valores fossem iguais, eles eram armazenados no vetor C. Após o algoritimo atestar que os valores dos vetores A e B eram iguais, ele somava 1 na variavel auxiliar C. Após isso ele trocava os indices para fazer o processo reverso e soma na variavel aux. Se a variavel aux fosse = 0, ele adicionava os valores de Vetor A [i] no vetor D. Em seguida ele printava os Vetores C (elementos comuns) e D (elementos diferentes) na tela.

### Resolução:
[!(https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/main/relatorio/Laboratorio%201/img/Lab1-Ex3.png)](https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/f0cf8351337e4b915237993d04b05b04a725aea8/relatorio/Laboratorio%201/img/Lab1-Ex3.png)

___
# **Exercício 4** 
___
##### Foi feito um programa que somava as linhas e colunas de uma matriz

##### Foi criado um laço de repetição dentro do outro, para preencher a matriz com valores informados pelo usuário. Após isso, foi criado mais um laço duplo de repetição para somar os valores das linhas da matriz. O valor foi armazenado em uma variavel e printado na tela (para cada uma das linhas). O mesmo foi feito para somar as colunas, porém, inventendo os indices (para pegar as colunas e não as linhas, já que não se trata de uma matriz perfeita). Armazei os resultados em outra variavel e eles foram printados na tela.

### Resolução:
[!(relatorio/Laboratorio 1/img/Lab1-Ex1.png)](https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/f0cf8351337e4b915237993d04b05b04a725aea8/relatorio/Laboratorio%201/img/Lab1-Ex4.png)

___
# **Exercício 5** 
___
##### Nesse exercício fez-se um algoritimo capaz de calcular o fatorial de um número n informado pelo usuário.

##### Foi criada uma função que recebia um número inteiro. Dentro dessa função foi criado um laço de repetição para percorrer o número - 1, até o número ser igual a 1. Dentro da repetição fez-se a multiplicação do número informado pelo usuário vezes o indice. No fim, a função retornou o fatorial.

### Resolução:
[!(https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/main/relatorio/Laboratorio%201/img/Lab1-Ex5.png)](https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/f0cf8351337e4b915237993d04b05b04a725aea8/relatorio/Laboratorio%201/img/Lab1-Ex5.png)

___
# **Exercício 6** 
___
##### Foi feito um algoritimo para calcular x^y, utilizando a passagem de valores por referência

##### Foi criada uma função que recebia dois números (base e expoente) e o resultado como parametro referência. A função utilizou a propriedade do C# Math.Pow para fazer a potenciação. O resultado foi armazenado na variavel res e retornado.

### Resolução:
[!(https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/main/relatorio/Laboratorio%201/img/Lab1-Ex6.png)](https://github.com/AED-PCO/lab-aed-pco-2022-2-gabriellaxdantas/blob/f0cf8351337e4b915237993d04b05b04a725aea8/relatorio/Laboratorio%201/img/Lab1-Ex6.png)


