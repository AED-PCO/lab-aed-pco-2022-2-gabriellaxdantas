int [] insertionSort (int [] vetor){
    int i, j, posAtual;
    for (i = 1; i < vetor.Length; i++){
        posAtual = vetor[i];
        j = i;
    while (j > 0 && vetor[j-1] > posAtual){
         vetor[j] = vetor[j - 1];
         j = j - 1;
    }
    vetor[j] = posAtual;
    }
    return vetor;
}

int [] vetor = new int [10] {89, 22, 89, 1, 5, 13, 19, 34, 38, 680};
Console.WriteLine("Os valores do vetor são:");
for(int i = 0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}

insertionSort(vetor);

Console.WriteLine("\nVetor ordenado:");
for(int i =0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}
