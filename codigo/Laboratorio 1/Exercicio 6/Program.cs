
    double res=0, x, y, aux;

    Console.WriteLine("Informe o valor da base:");
        x = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o valor do expoente:");
        y = double.Parse(Console.ReadLine());

    aux = calculaPotencia(x, y, ref res);
    Console.WriteLine(aux);

    double calculaPotencia (double x, double y, ref double res){
        res = Math.Pow(x,y);
            return (res);
    }