// Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
// Considere que nenhum dos vetores possui elementos repetidos.

// Crie um vetor resultante C que possua os elementos comuns entre A e B.
// Crie um vetor resultante D que contenha os elementos de A que não existam em B.

    int[] vetorA = new int[5];
    int[] vetorB = new int[5];
    int[] vetorC = new int[5];
    int[] vetorD = new int[5];
    int auxC = 0, auxD = 0, aux = 0;

    Console.WriteLine("Informe os valores para o vetor A:");
        for(int i =0; i< vetorA.Length; i++){
                vetorA[i] = int.Parse(Console.ReadLine());
        }

    Console.WriteLine("Informe os valores para o vetor B:");
        for(int i =0; i< vetorB.Length; i++){
                vetorB[i] = int.Parse(Console.ReadLine());
        }


    for (int i = 0; i < vetorB.Length; i++){
        for (int j = 0; j < vetorA.Length; j++){
            if (vetorA[j] == vetorB[i]){
                vetorC[auxC] = vetorA[j];
                auxC++;
            }
            if (vetorA[i] == vetorB[j]) 
                aux++;
        }
            if (aux == 0){
                vetorD[auxD] = vetorA[i];
                auxD++;
            }
                aux = 0;
    }
    Console.WriteLine("Os elementos comuns entre os vetores A e B são:");
        for (int i = 0; i < vetorC.Length; i++){
                if (vetorC[i] != 0){
                    Console.WriteLine(vetorC[i]);
                }
        }

    Console.WriteLine("Os elementos que existem no vetor A mas não existem no vetor B são:");
        for (int i = 0; i < vetorD.Length; i++){
            if (vetorD[i] != 0){
                    Console.WriteLine(vetorD[i]);
            }
        }