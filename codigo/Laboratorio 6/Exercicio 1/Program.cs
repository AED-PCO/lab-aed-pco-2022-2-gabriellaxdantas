
int [] bubleeSort (int [] vetor){
    int tam = vetor.Length;
    int trocas = 0;
    int comparacoes = 0;

        for (int i = tam - 1; i >= 1; i --){
            for (int j = 0; j < i; j ++){
                comparacoes++;
                if (vetor[j] > vetor [j + 1]){
                    int aux = vetor[j];
                    vetor[j] = vetor [j+1];
                    vetor [j+1] = aux;
                    trocas ++;
                }
            }
        }
        return vetor;
}

int [] vetor = new int [10] {0, 7, 8, 12, 16, 34, 87, 1, 165, 9};

bubleeSort(vetor);

for (int i = 0; i < vetor.Length; i++){
    Console.Write(vetor [i] + " ");
}



