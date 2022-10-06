// Faça a busca binária sem a utilização da variável pos

int buscaBinaria (int []vetor, int val, int inicio, int fim){
    int mid = (inicio + fim)/2;
        if (vetor [mid] == val)
            return mid;
        else if (vetor[mid] > val){
                return buscaBinaria(vetor, val, inicio, (mid - 1));
        }
        else if (vetor [mid] < val){
            return buscaBinaria(vetor, val, (mid +1), fim);
        }
        else
            return (-1);
}

int numero, res;
int [] vetor = new int [10] {1, 8, 10, 24, 32, 40, 50, 52, 60, 64};
Console.WriteLine("Os valores do vetor são:");
    for(int i =0; i<10; i++){
        Console.Write(vetor[i] + "  "  );
        
    }
    Console.WriteLine("De qual valor do vetor você gostaria de saber a posição?");
    numero = int.Parse(Console.ReadLine());

    res = buscaBinaria (vetor, numero, 0, vetor.Length-1);
    Console.WriteLine("O valor {0} está na posição: {1}",numero, res);