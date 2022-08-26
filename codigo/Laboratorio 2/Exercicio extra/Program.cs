// Faça uma definição recursiva da série de 
// Fibonacci

    int retornaFibonacci (int x){
        if (x == 1)
            return (0);
        if (x == 2)
            return (1);
        else
            return retornaFibonacci (x - 1) + retornaFibonacci (x - 2);
}

    int x, res;
    Console.WriteLine("Informe qual a posição da sequência de fibonacci que você quer descobrir:");
        x = int.Parse(Console.ReadLine());

    res = retornaFibonacci(x);
        Console.WriteLine("O resultado da sequência de Fibonacci para a posição {0} começando de 0 é: {1}", x, res);
