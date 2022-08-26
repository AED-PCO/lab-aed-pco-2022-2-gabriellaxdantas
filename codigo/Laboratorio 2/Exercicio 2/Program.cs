//     Uma multiplicação pode ser vista como uma 
// sequência de somas. Escreva um método 
// recursivo que realize a multiplicação de dois 
// números inteiros, A e B, recebidos por 
// parâmetro.

    int A, B, res=0;
    Console.WriteLine("Insira o primeiro número:");
        A=int.Parse(Console.ReadLine());

    Console.WriteLine("Insira o segundo número:");
        B=int.Parse(Console.ReadLine());

    int multiplicacao (int A, int B){
        if (B==1)
            return(A);
        else if (A == 0) 
            return (0);
        int aux = 0;
            aux = A + multiplicacao(A, B-1);
                return(aux);
    }

    res=multiplicacao(A, B);
        Console.WriteLine("O resultado de {0} x {1} é: {2}", A,B, res);

