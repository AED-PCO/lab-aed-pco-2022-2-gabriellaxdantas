
namespace Fila
{
    class Program
    {
        static void adicionar(int[] fila, ref int qtd, int n)
        {
            fila[qtd] = n;
            qtd++;
        }
        static int remover(int[] fila, ref int qtd)
        {
            int n = fila[0];

            for (int i = 0; i < qtd - 1; i++)
                fila[i] = fila[i + 1];

            qtd--;
            return n;
        }
        static char validar(char c, int n)
        {
            Console.WriteLine();
            if (n == 1)
            {
                while (c != 'S' && c != 's' && c != 'n' && c != 'N')
                {
                    Console.Write("Informe um valor valido. 's' para SIM ou 'n' para NÃO. ");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                return c;
            }
            else
            {
                while (c != 'a' && c != 'A' && c != 'r' && c != 'R')
                {
                    Console.WriteLine("Informe um valor valido. Digite 'a' para ACRESCENTAR e 'r' para REMOVER: ");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                return c;
            }
        }
        static void imprime(int[] vetor, int qtd)
        {
            Console.Write("A fila é: ");

            for (int i = 0; i < qtd; i++)
                Console.Write(vetor[i] + " ");

            Console.WriteLine();
        }
        const int tam = 10;
        static void Main(string[] args)
        {
            char repetir;
            int[] fila = new int[tam] { 10, 20, 30, 40, 50, 0, 0, 0, 0, 0 };
            int qtd = 5;
            imprime(fila, qtd);

            do
            {
                Console.WriteLine("Deseja acrescentar ou retirar um número? 'a' para ACRESCENTAR, 'r' para REMOVER: ");
                char valid = Console.ReadKey().KeyChar;
                valid = validar(valid, 2);

                if (valid == 'a' || valid == 'A')
                {
                    if (qtd >= tam)
                    {
                        Console.WriteLine("A fila está cheia. Remova um item para adicionar.");
                    }
                    else
                    {
                        Console.WriteLine("Informe um número para ser adicionado a fila: ");

                        adicionar(fila, ref qtd, int.Parse(Console.ReadLine()));
                        imprime(fila, qtd);
                    }
                }
                else
                {
                    if (qtd <= 0)
                    {
                        Console.WriteLine("A fila se encontra vazia.");
                    }
                    else
                    {
                        Console.WriteLine("O número {0} foi removido da fila.", remover(fila, ref qtd));

                        imprime(fila, qtd);
                    }
                }
                Console.WriteLine("Deseja continuar? Digite 's' para SIM ou 'n' para NÃO.");
                repetir = Console.ReadKey().KeyChar;
                repetir = validar(repetir, 1);

            } while (repetir == 'S' || repetir == 's');
            
            imprime(fila, qtd);
        }
    }
}