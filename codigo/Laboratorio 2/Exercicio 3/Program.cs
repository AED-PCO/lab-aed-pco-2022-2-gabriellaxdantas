//  Escreva um método recursivo que realize a 
// potenciação entre dois números inteiros, A 
// e B, recebidos por parâmetro. Seu método 
// deve, portanto, retornar o resultado de AB

int A, B, res=0;
Console.WriteLine("Informe o valor da base:");
A=int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor do expoente:");
B=int.Parse(Console.ReadLine());

    int ponteciacao (int A, int B){
        if(B==0)
        return(1);
    int aux = 0;
        aux = A * ponteciacao(A, B-1);
        return(aux);
    }

    res = ponteciacao (A, B);
        Console.WriteLine("O resultado de {0} elevado a {1} é {2}", A, B, res);
