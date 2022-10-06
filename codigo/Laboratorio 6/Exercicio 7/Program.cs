 int[] countingSort(int[] vetor)
        {
            int minimo = vetor[0], maximo = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < minimo) minimo = vetor[i];
                if (vetor[i] > maximo) maximo = vetor[i];
            }
            int[] cont = new int[maximo - minimo + 1];
            for (int i = 0; i < vetor.Length; i++)
            {
                cont[vetor[i] - minimo]++;
            }
            for (int i = 1; i < cont.Length; i++)
            {
                cont[i] += cont[i - 1];
            }
            int[] aux = new int[vetor.Length];
            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                aux[cont[vetor[i] - minimo] - 1] = vetor[i];
                cont[vetor[i] - minimo]--;
            }
            return aux;
        }

        const int tamanho = 10;
        int[] vetor = new int[tamanho] {10, 2, 8, 2, 8, 9, 5, 10, 1, 6};
        Console.WriteLine("Os valores presentes no vetor são:");
        for(int i = 0; i < tamanho; i++){
            Console.Write(vetor[i] + " ");
        }
        vetor = countingSort(vetor);
        Console.WriteLine("\nVetor ordenado:");
        for(int i = 0; i < tamanho; i++){
            Console.Write(vetor[i] + " ");
        }