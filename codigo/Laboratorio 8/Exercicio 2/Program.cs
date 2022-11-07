namespace Lista
{
    class Program
    {
        static void adicionar(int[] lista, int flag, ref int qtd, int n)
        {
            if (flag < qtd)
                for (int i = qtd; i > flag; i--)
                    lista[i] = lista[i - 1];

            lista[flag] = n;
            qtd++;
        }
        static int remover(int[] lista, int pos, ref int qtd)
        {
            int n = lista[pos];

            for (int i = pos; i < qtd - 1; i++)
                lista[i] = lista[i + 1];

            qtd--;
            return n;
        }
        static int procurar(int[] vetor, int tam, int numero)
        {
            for (int i = 0; i < tam; i++)
                if (vetor[i] == numero)
                    return i;
            return -1;
        }
        static char validar(char c, int n)
        {
            Console.WriteLine();
            if (n == 1 || n == 3)
            {
                while (c != 'S' && c != 's' && c != 'n' && c != 'N')
                {
                    Console.WriteLine("Informe valores validos. 's' para SIM, 'n' para NÃO. ");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                return c;
            }
            else
            {
                while (c != 'a' && c != 'A' && c != 'r' && c != 'R')
                {
                    Console.WriteLine("Informe um valor valido. 'a' para ADICIONAR 'r' para REMOVER: ");
                    c = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                return c;
            }
        }
        static void imprime(int[] vetor, int qtd)
        {
            Console.Write("A lista é: ");
            for (int i = 0; i < qtd; i++)
                Console.Write(vetor[i] + " ");

            Console.WriteLine();
        }
        const int tam = 10;
        static void Main(string[] args)
        {
            char repetir;
            int[] lista = new int[tam] { 10, 20, 30, 40, 50, 0, 0, 0, 0, 0 };
            int qtd = 5;
            imprime(lista, qtd);

            do
            {
                Console.WriteLine("Deseja adicionar ou remover algum valor? Digite 'a' para ACRESCENTAR ou 'r' para REMOVER. ");
                char valid = Console.ReadKey().KeyChar;
                valid = validar(valid, 2);

                if (valid == 'a' || valid == 'A')
                {
                    if (qtd >= tam)
                    {
                        Console.WriteLine("Lista Cheia");
                    }
                    else
                    {
                        Console.WriteLine("Informe um valor para ser adicionado a lista: ");
                        int n = int.Parse(Console.ReadLine());

                        Console.WriteLine("Você deseja adicionar esse valor em uma posição especifíca? Digite 's' para SIM ou 'n' para NÃO. ");
                        char valida = Console.ReadKey().KeyChar;
                        valida = validar(valida, 3);
                        int flag = qtd;

                        if (valida == 's' || valida == 'S')
                        {
                            Console.WriteLine("Informe a posição onde o valor será inserido:");
                            flag = int.Parse(Console.ReadLine());

                            while (flag > lista.Length - 1 || flag < 0)
                            {
                                Console.WriteLine("Informe uma posição valida: ");
                                flag = int.Parse(Console.ReadLine());
                            }

                            flag--;
                        }
                        if (flag > qtd)
                        {
                            flag = qtd;
                            Console.WriteLine("Existem posições livres na lista. A posição foi definida para {0}°", flag + 1);
                        }

                        adicionar(lista, flag, ref qtd, n);
                        imprime(lista, qtd);
                    }
                }
                else
                {
                    if (qtd <= 0)
                    {
                        Console.WriteLine("A lista se encontra vazia");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Informe o valor que você deseja remover: ");
                        int n = int.Parse(Console.ReadLine());
                        int num = procurar(lista, qtd, n);

                        if (num == -1)
                        {
                            Console.WriteLine("O valor {0} não se encontra na lista.", n);
                        }
                        else
                        {
                            Console.WriteLine("O valor {0} foi removido da lista.", remover(lista, num, ref qtd));
                            imprime(lista, qtd);
                        }
                    }
                }
                Console.WriteLine("Deseja continuar? Digite 's' para SIM ou 'n' para NÃO.");
                repetir = Console.ReadKey().KeyChar;
                repetir = validar(repetir, 1);

            } while (repetir == 'S' || repetir == 's');

            imprime(lista, qtd);
        }
    }
}