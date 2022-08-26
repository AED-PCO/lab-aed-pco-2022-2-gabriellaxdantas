//     Escreva um método recursivo que retorne o 
// fatorial de um número.

    int n, res=0;
    Console.WriteLine("Informe o número que deseja calcular o fatorial:");
        n = int.Parse(Console.ReadLine());

    int fatorial (int n){
        if(n==2)
            return(2);
    int auxiliar = 0;
        auxiliar=n*fatorial (n-1);
            return (auxiliar);
    }

    res = fatorial(n);
    Console.WriteLine("O fatorial de {0} é {1}", n, res);



