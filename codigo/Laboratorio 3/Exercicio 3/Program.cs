int procurar(int [] vetor, int inicio, int tamanho, int numero, int pos) {

     if (inicio <= tamanho)
            {
                int metade = inicio + (tamanho - inicio) / 2;
                if (vetor[metade] == numero) return pos = metade + 1;
                if (vetor[metade] > numero) return procurar(vetor, inicio, metade - 1, numero, pos);
                return procurar(vetor, metade + 1, tamanho, numero, pos);
            }
            pos = -1;
            return pos;
}

const int tamanho = 5;
int pos = 0;
int[] vetor = new int[tamanho] { 15, 32, 47, 60, 99 };
Console.WriteLine("Os valores do vetor são:");
for(int i = 0; i < tamanho; i++){
    Console.Write(vetor [i] + " ");
}
 Console.WriteLine("\nDigite o número que você deseja saber a posição no vetor: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("O valor {0} se encontra na {1}° posição do vetor", n, procurar(vetor, 0, tamanho - 1, n, pos));
