namespace Pilha
{
    class Program
    {
        static void adicionar(int[] pilha, ref int qtd, int n)
        {
            pilha[qtd] = n;
            qtd++;
        }
        static int remover(int[] pilha, ref int qtd)
        {
            qtd--;
            return pilha[qtd];
        }
        static char validar(char c, int n)
        {
            Console.WriteLine();
            if (n == 1)
            {
                while (c != 'S' && c != 's' && c != 'n' && c != 'N')
                {
                    Console.WriteLine("Digite um valor valido. 's' para SIM ou 'n' para NÃO. ");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                return c;
            }
            else
            {
                while (c != 'a' && c != 'A' && c != 'r' && c != 'R')
                {
                    Console.WriteLine("Informe um valor valido. 'a' para ACRESCENTAR ou 'r' para REMOVER. ");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                return c;
            }
        }
        static void imprime(int[] vetor, int qtd)
        {
            Console.Write("A pilha é: ");

            for (int i = 0; i < qtd; i++)
                Console.Write(vetor[i] + " ");
            Console.WriteLine();
        }
        const int tamanho = 10;
        static void Main(string[] args)
        {
            char repetir;
            int[] pilha = new int[tamanho] { 10, 20, 30, 40, 50, 0, 0, 0, 0, 0 };
            int qtd = 5;
            imprime(pilha, qtd);

            do
            {
                Console.WriteLine("Deseja adicionar ou remover algum valor a pilha? Digite 'a' para ACRESCENTAR ou 'r' para REMOVER. ");
                char valid = Console.ReadKey().KeyChar;
                valid = validar(valid, 2);

                if (valid == 'a' || valid == 'A')
                {
                    if (qtd >= tamanho)
                    {
                        Console.WriteLine("A pilha se encontra cheia. Remova algum valor para conseguir adicionar.");
                    }
                    else
                    {
                        Console.WriteLine("Informe um valor para ser adicionado a pilha: ");
                        adicionar(pilha, ref qtd, int.Parse(Console.ReadLine()));
                        imprime(pilha, qtd);
                    }
                }
                else
                {
                    if (qtd <= 0)
                    {
                        Console.WriteLine("A pilha se encontra vazia.");
                    }
                    else
                    {
                        Console.WriteLine("O valor {0} foi removido da pilha.", remover(pilha, ref qtd));

                        imprime(pilha, qtd);
                    }
                }
                Console.WriteLine("Deseja continuar? Digite 's' para SIM ou 'n' para NÃO. ");
                repetir = Console.ReadKey().KeyChar;
                repetir = validar(repetir, 1);

            } while (repetir == 'S' || repetir == 's');
            
            imprime(pilha, qtd);
        }
    }
}