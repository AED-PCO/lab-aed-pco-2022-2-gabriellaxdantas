# Exercício 3:


#### **1 – Operação mais relevante?**
#### A operação mais relevante desse algoritimo é res[pos] += arr1[pos]/arr1[j].

#### **2 – Marcar operações**
#### As operações presentes são: 
#### atribuição (pos = 0, j = 0)
#### comparação (if(j!=pos))
#### incremento (pos++, j++)


#### **3 – Avaliar sequências e laços**
#### O primeiro laço está indo de pos= = 0 até < vetor.Lenght e dentro dele temos um outro for que vai de j= 0 até < vetor.Lenght. Dentro desse segundo for está ocorrendo um desvio com o if para verificar se o valor de pos é diferente do valor de j. Caso seja verdadeiro, ele faz a soma e atribuição de vetor[pos]/vetor[j] em um vetor auxiliar res [pos]. Ao fim ele retornará o valor armazenado dentro desse vetor.


#### **4 – Há variação de casos?**
#### Nesse caso não haverá variação pois o independetemente do tamanho do vetor, sempre haverá diferença entre pos e j, sendo assim, ele entrará no if de qualquer maneira.
