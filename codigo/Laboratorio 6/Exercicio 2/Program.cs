int [] selectionSort (int [] vetor){
    int menorValor;
    int aux;
        for (int i = 0; i < vetor.Length - 1; i++){
            menorValor = i;
            for (int j = i + 1; j < vetor.Length; j++){
                if (vetor[j] < vetor[menorValor]){
                    menorValor = j;
                }
            }
            if (menorValor != i){
                aux = vetor[menorValor];
                vetor [menorValor]= vetor [i];
                vetor [i] = aux;
            }
        }
        return vetor;
}

int [] vetor = new int [10] {10, 17, 89, 1, 5, 13, 14, 34, 8, 68};

selectionSort(vetor);

for(int i =0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}
