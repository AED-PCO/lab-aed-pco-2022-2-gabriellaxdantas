 class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine("Árvore ABB");
            ArvoreBinaria Arvore = new ArvoreBinaria();
            int valid;
            do
            {
                Console.Write("\nInserir [1] / Remover [2] / Procurar Valor [3] / Em Ordem [4] / Pré-Ordem [5] / Pós-Ordem [6] / Sair [7]: ");
                valid = int.Parse(Console.ReadLine());
                if (valid == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nDigite o valor a ser inserido na árvore: ");
                    Console.ResetColor();
                    Arvore.inserir(int.Parse(Console.ReadLine()));
                }
                else if (valid == 2)
                {

                    Console.Write("\nDigite o valor a ser removido da árvore: ");

                    Arvore.remover(int.Parse(Console.ReadLine()));
                }
                else if (valid == 3)
                {

                    Console.Write("\nDigite o número a ser procurado na árvore: ");

                    int num = int.Parse(Console.ReadLine());
                    bool existe = Arvore.pesquisa(num);
                    if (existe)
                    {
     
                        Console.WriteLine("\nO valor {0} está presente na árvore", num);

                    }
                    else
                    {
   
                        Console.WriteLine("\nO valor {0} não está presente na árvore", num);

                    }
                }
                else if (valid == 4)
                {
                    Arvore.emOrdem();
                }
                else if (valid == 5)
                {
                    Arvore.preOrdem();
                }
                else if (valid == 6)
                {
                    Arvore.posOrdem();
                }
                else if (valid != 7)
                {

                    Console.WriteLine("\nDigite um valor válido");

                }
            }
            while (valid != 7);
        }
    }