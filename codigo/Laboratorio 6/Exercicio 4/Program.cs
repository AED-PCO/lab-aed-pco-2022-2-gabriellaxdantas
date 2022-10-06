static void shellSort(int[] vetor) {
    int h = 1;
    int n = vetor.Length;

    while (h < n){
         h = h * 3 + 1;
    }
    h = h / 3;
    int c, j;

    while (h > 0){
        for (int i = h; i < n; i++){
            c = vetor[i];
            j = i;
                while (j >= h && vetor[j - h] > c){
                     vetor[j] = vetor[j - h];
                    j = j - h;
                }
             vetor[j] = c;

        }
        h = h / 2;
    }
}

int [] vetor = new int [10] {58, 19, 7, 22, 12, 13, 987, 34, 1, 68};
Console.WriteLine("Os valores do vetor são:");
for(int i = 0; i<vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}

shellSort(vetor);

Console.WriteLine("\n Vetor ordenado:");
for(int i =0; i < vetor.Length; i++){
    Console.Write(vetor[i] + " ");
}