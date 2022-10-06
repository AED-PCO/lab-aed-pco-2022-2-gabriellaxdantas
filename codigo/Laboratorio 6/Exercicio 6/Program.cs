 void mergeSort(int[] vetor, int inicio, int tamanho)
        {
            if (inicio < tamanho)
            {
                int metade = inicio + (tamanho - inicio) / 2;
                mergeSort(vetor, inicio, metade);
                mergeSort(vetor, metade + 1, tamanho);
                organiza(vetor, inicio, metade, tamanho);
            }
        }

void organiza(int[] vetor, int inicio, int metade, int tamanho)
        {
            int i, j, k;
            int parte1 = metade - inicio + 1;
            int parte2 = tamanho - metade;
            int[] vetor1 = new int[parte1];
            int[] vetor2 = new int[parte2];
            for (i = 0; i < parte1; i++) vetor1[i] = vetor[inicio + i];
            for (j = 0; j < parte2; j++) vetor2[j] = vetor[metade + 1 + j];
            i = 0;
            j = 0;
            k = inicio;
            for (; i < parte1 && j < parte2; k++)
            {
                if (vetor1[i] <= vetor2[j])
                {
                    vetor[k] = vetor1[i];
                    i++;
                }
                else
                {
                    vetor[k] = vetor2[j];
                    j++;
                }
            }
            for (; i < parte1; i++, k++) vetor[k] = vetor1[i];
            for (; j < parte2; j++, k++) vetor[k] = vetor2[j];
        }

        const int tamanho = 10;
        int[] vetor = new int[tamanho] {1289, 10, 7, 69875, 123, 98, 897, 20, 31, 19};
        Console.WriteLine("Os valores presentes no vetor são:");
        for(int i = 0; i<tamanho; i++){
            Console.Write(vetor[i] + " ");
        }
         mergeSort(vetor, 0, vetor.Length - 1);
        Console.WriteLine("\nVetor ordenado:");
        for(int i = 0; i< tamanho; i++){
            Console.Write(vetor[i] + " ");
        }