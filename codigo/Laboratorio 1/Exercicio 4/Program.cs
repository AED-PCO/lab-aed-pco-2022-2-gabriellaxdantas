//Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 

    int [,] matriz = new int [5,3];
    int [] somaLinha = new int [5];
    int [] somaColuna = new int [3];
    int i, j;

    for(i=0; i<5; i++){
        Console.WriteLine("Linha {0}", i);
            for(j=0; j<3; j++){
                Console.WriteLine("Informe um valor para a coluna {0}", j);
                matriz[i,j]=int.Parse(Console.ReadLine());
            }
    }
// Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.
    for (i=0; i<5; i++){
        for(j=0; j<3; j++){
            somaLinha[i]+=matriz[i,j];
        }
        Console.WriteLine("A soma da linha {0} é {1}", i, somaLinha[i]);
    }

    for(j=0; j<3; j++){
        for (i=0; i<5; i++){
            somaColuna[j]+=matriz[i,j];
        }
        Console.WriteLine("A soma da coluna {0} é {1}", j, somaColuna[j]);
    }