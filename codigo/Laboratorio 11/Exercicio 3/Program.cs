  class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Lista Circular Dinâmica");
            Listas lista = new Listas();
            int valid;
            do
            {
                Console.Write("Inserir [1] / Remover [2] / Sair [3]: ");
                valid = int.Parse(Console.ReadLine());
                if (valid == 1)
                {

                    Console.Write("Digite algo: ");

                    string num = Console.ReadLine();
                    Console.Write("Deseja adicionar em uma posição especifica? [1 = Sim / 2 = Não] ");
                    int val = int.Parse(Console.ReadLine());
                    if (val == 1)
                    {
                        Console.Write("Em qual posição deseja adicionar? ");
                        lista.adicionar(num, int.Parse(Console.ReadLine()));
                    } 
                    else if (val == 2)
                    {
                        lista.adicionar(num);
                    }
                    else
                    {

                        Console.WriteLine("Valor informado é invalido");
;
                    }
                    lista.imprimi();
                }
                else if (valid == 2)
                {
                    int validar = lista.remover();
                    if (validar == -1)
                    {

                        Console.WriteLine("Lista Vazia");

                    }
                    else
                    {
                        Console.Write("Qual elemento deseja remover? ");
                        string n = lista.remover(Console.ReadLine());
                        if (n != "")
                        {

                            Console.WriteLine("O elemento '{0}' foi removido", n);

                        }
                        lista.imprimi();
                    }
                }
                else if (valid != 3)
                {

                    Console.WriteLine("Digite um valor valido!");

                }
            } while (valid != 3);

            lista.imprimi();

        }
    }