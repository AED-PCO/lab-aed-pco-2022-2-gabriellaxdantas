//     Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras
// palavras, um Número Primo possui dois divisores de 1 até ele.

// Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é
// Primo.
    int num, div=0;
    Console.WriteLine("Informe um número inteiro:");
    num = int.Parse(Console.ReadLine());

    for(int i=1; i<=num; i++){
        if(num%i==0)
        div+=1;
    }

    if(div==2)
        Console.WriteLine("O número {0} é primo!", num);
        else Console.WriteLine("O número {0} não é primo!",num);

// Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por
// exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
// Faça um programa que liste os números perfeitos de 1 a 1000.

     int k, soma, l, metade;

    for(k=1; k<=1000; k++){
        metade=k/2;
        soma=0;
            for(l=1; l<=metade; l++){
                if(k%l==0)
                soma+=l;
            }
            if(soma==k)
            Console.WriteLine("O número {0} é perfeito!", k);
           }