 class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            pilha fila = new pilha();
            int valid;
            do
            {
                Console.WriteLine("O QUE VOCÊ DESEJA FAZER?\n1) Acrescentar   2) Remover   3) Sair: ");
                valid = int.Parse(Console.ReadLine());
                if (valid == 1){
                    Console.Write("Informe um valor a ser inserido na fila: ");
                    fila.acrescentar(Console.ReadLine());
                    fila.imprime();
                }
                else if (valid == 2){
                    string n = fila.remover();
                    if (n != ""){
                        Console.WriteLine("O valor {0} foi removido da fila.", n);
                        Console.ResetColor();
                        fila.imprime();
                    }
                }
                else if (valid != 3){
                 Console.WriteLine("Informe um valor válido para continuar. 1 para ACRESCENTAR, 2 para REMOVER ou S para SAIR:");
                }
            } while (valid != 3);

            fila.imprime();
        }
    }