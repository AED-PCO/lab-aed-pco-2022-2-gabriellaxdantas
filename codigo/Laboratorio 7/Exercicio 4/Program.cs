    String GeradorCPF()
    {
        int soma = 0, resto = 0;
        int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        Random rnd = new Random();
        string semente = rnd.Next(100000000, 999999999).ToString();

        for (int i = 0; i < 9; i++)
            soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

        resto = soma % 11;
        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        semente = semente + resto;
        soma = 0;

        for (int i = 0; i < 10; i++)
            soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

        resto = soma % 11;

        if (resto < 2)
            resto = 0;
        else
            resto = 11 - resto;

        semente = semente + resto;
        return semente;
    }

    for (int i = 0; i < 10; i++){
        Console.WriteLine(GeradorCPF());
    }
    


 
 
 void mergeSort(string [] vetor, int inicio, int tamanho)
        {
            if (inicio < tamanho)
            {
                int metade = inicio + (tamanho - inicio) / 2;
                mergeSort(vetor, inicio, metade);
                mergeSort(vetor, metade + 1, tamanho);
                organiza(vetor, inicio, metade, tamanho);
            }
        }

void organiza(string [] vetor, int inicio, int metade, int tamanho)
        {
            int i, j, k;
            int parte1 = metade - inicio + 1;
            int parte2 = tamanho - metade;
            string[] vetor1 = new string[parte1];
            string[] vetor2 = new string [parte2];
            for (i = 0; i < parte1; i++) vetor1[i] = vetor[inicio + i];
            for (j = 0; j < parte2; j++) vetor2[j] = vetor[metade + 1 + j];
           i = 0;
            j = 0;
            k = inicio;
            for (; i < parte1 && j < parte2; k++)
            {
                float n1 = float.Parse(vetor1[i]);
                float n2 = float.Parse(vetor2[j]);
                if (n1 <= n2)
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

         string[] CPFs = new string [50000];
            for (int i = 0; i < CPFs.Length; i++) 
            CPFs[i] = GeradorCPF();

            for (int i = 0; i < CPFs.Length; i++) 
            Console.WriteLine(CPFs[i]);

            mergeSort(CPFs, 0, CPFs.Length - 1);
            Console.WriteLine("\nOrdenados:\n");
            for (int i = 0; i < CPFs.Length; i++) Console.WriteLine(CPFs[i]);
        