 int procurar(int[] vetor, int inicio, int tamanho, int numero){
            if (inicio <= tamanho)
            {
                int metade = inicio + (tamanho - inicio) / 2;
                if (vetor[metade] == numero) return metade + 1;
                if (vetor[metade] > numero) return procurar(vetor, inicio, metade - 1, numero);
                return procurar(vetor, metade + 1, tamanho, numero);
            }
            return -1;
}

 const int tamanho = 10;
int[] vetor = new int[tamanho] { 120, 128, 298, 1576, 1876, 1900, 1907, 1921, 3565, 10198 };
           
Console.WriteLine("Informe o número que deseja procurar no vetor: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("O número {0} está na {1}° posição do vetor", n, procurar(vetor, 0, tamanho - 1, n));