 class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            lista lista = new lista();
            int valid;
            do{
                Console.WriteLine("O QUE VOCÊ DESEJA FAZER?\n1) Acrescentar   2) Remover   3) Sair: ");
                valid = int.Parse(Console.ReadLine());
                if (valid == 1){
                    Console.Write("Informe um valor a ser inserido na fila: ");
                    Console.ResetColor();
                    string num = Console.ReadLine();
                    if (lista != null){
                    Console.WriteLine("DESEJA INSERIR O VALOR EM UMA POSIÇÃO ESPECÍFICA?\n1) Sim   2) Não:");
                    int val = int.Parse(Console.ReadLine());
                    if (val == 1)
                    {
                        Console.Write("Em qual posição você deseja acrescentar o valor? ");
                        lista.acrescentar(num, int.Parse(Console.ReadLine()));
                    } 
                    else if (val == 2)
                    {
                        lista.acrescentar(num);
                    }
                    else{
                        Console.WriteLine("VALOR INFORMADO INVÁLIDO");
                    }
                    lista.imprime();
                    }
                }
                else if (valid == 2){
                    int validar = lista.remover();
                    if (validar == -1){
                        Console.WriteLine("A lista se encontra vazia.");
                        Console.ResetColor();
                    }
                    else{
                        Console.Write("Qual valor você deseja remover? ");
                        string n = lista.remover(Console.ReadLine());
                        if (n != ""){
                            Console.WriteLine("O valor {0} foi removido da lista.", n);
                        }
                        lista.imprime();
                    }
                }
                else if (valid != 3){
                    Console.WriteLine("Informe um valor válido para continuar. 1 para ACRESCENTAR, 2 para REMOVER ou 3 para SAIR:");
                    Console.ResetColor();
                }
            } while (valid != 3);

            lista.imprime();
        }
    }