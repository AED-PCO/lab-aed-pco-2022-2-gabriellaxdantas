 static void swap(int[] vetor, int inicio, int tam)
        {
            int aux = vetor[inicio];
            vetor[inicio] = vetor[tam];
            vetor[tam] = aux;
        }
        static void quickSort(int[] vetor, int inicio, int tam)
        {
            if (tam > inicio)
            {
                int pivo = particiona(vetor, inicio, tam);
                quickSort(vetor, inicio, pivo - 1);
                quickSort(vetor, pivo + 1, tam);
            }
        }
        static int particiona(int[] vetor, int inicio, int tam)
        {
            int pivo = vetor[tam];
            int i = (inicio - 1);
            for (int j = inicio; j <= tam - 1; j++)
            {
                if (vetor[j] < pivo)
                {
                    i++;
                    swap(vetor, i, j);
                }
            }
            swap(vetor, i + 1, tam);
            return (i + 1);
        }

         const int tam = 10;
            int[] vetor = new int[tam] {125, 12, 98, 45, 1, 469, 3, 0, 78, 999};
            Console.WriteLine("Os valores do vetor são:");
            for(int i = 0; i < vetor.Length; i++){
                Console.Write(vetor[i] + " ");
            }

            quickSort(vetor, 0, tam-1);
            Console.WriteLine("\nVetor ordenado:");
            for(int i =0; i< vetor.Length; i++){
                Console.Write(vetor[i] + " ");
            }