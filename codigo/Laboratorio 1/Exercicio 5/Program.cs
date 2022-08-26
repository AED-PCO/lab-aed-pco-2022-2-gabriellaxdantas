    int num, res;
        Console.WriteLine("Informe o número a ser calculado o fatorial:");
        num = int.Parse(Console.ReadLine());
    
    res = Fatorial (num);
        Console.WriteLine("O fatorial de {0} é: {1}", num, res);


    int Fatorial(int num){
        int fatorial = num;
            for(int i = num-1; i>=1; i--){
                fatorial *= i;
            }
                return fatorial;
    }