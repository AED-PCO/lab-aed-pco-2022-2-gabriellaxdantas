// Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
// Considere que nenhum dos vetores possui elementos repetidos.

// Crie um vetor resultante C que possua os elementos comuns entre A e B.
// Crie um vetor resultante D que contenha os elementos de A que não existam em B.

    int [] vetorA = new int [5];
    int [] vetorB= new int [5];
    int [] vetorC = new int [5];
    int [] vetorD = new int [5];
    int i, j, k=0;

    for(i=0; i<5; i++){
        Console.WriteLine("Informe um valor para a posição {0} do vetor A", i);
        vetorA[i]=int.Parse(Console.ReadLine());
    }

    for(i=0; i<5; i++){
        Console.WriteLine("Informe um valor para a posição {0} do vetor B", i);
        vetorB[i]=int.Parse(Console.ReadLine());
    }

    for (i = 0; i < 5; i++){
        for (j = 0; j < 5; j++){
            if (vetorA[i] == vetorB[j]){
                vetorC[k] = vetorA[i];
                k++;
            }
        }
    }

    Console.WriteLine("Vetor de elementos comuns entre A e B:");
    for(i=0; i<vetorC.Length; i++){
        Console.WriteLine(vetorC[i]);
    }

    for (i = 0; i < 5; i++){
        for (j = 0; j < 5; j++){
            if (vetorA[i] != vetorB[j]){
                vetorD[k] = vetorA[i];
                k++;
            }
        }
    }

    Console.WriteLine("Vetor de elementos de A que não existem em B:");
    for(int g=0; g<5; g++){
        Console.WriteLine(vetorD[g]);
    }
