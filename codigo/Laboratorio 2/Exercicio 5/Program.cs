//  Escreva um método recursivo que calcule a 
// soma dos elementos de valor par de um 
// vetor de números inteiros positivos.

    int somaPares(int []vetor, int i, int soma){
        if (i < 0){
                return (0);
        }
            soma=0;
        if ((vetor[i]) % 2 == 0){
            soma += (vetor[i]);
        }
        return soma + somaPares(vetor, i - 1, soma);
    }

    int [] vetor  = new int [4];
    int n = vetor.Length;
    int soma = 0 , res;
    
    for(int k=0; k<4; k++){
        Console.WriteLine("Informe um valor para a posição {0} do vetor", k);
        vetor[k]=int.Parse(Console.ReadLine());
    }
    res = somaPares(vetor, n - 1, soma);
    Console.Write("A soma dos pares é:{0}", res);
