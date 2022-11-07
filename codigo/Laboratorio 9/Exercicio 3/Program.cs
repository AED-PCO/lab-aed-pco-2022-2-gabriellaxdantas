 class Program
    {
        static void acrescentar(int[] lista, int flag, ref int qtd, int n)
        {
            if (flag < qtd)
                for (int i = qtd; i > flag; i--)
                    lista[i] = lista[i - 1];

            lista[flag] = n;
            qtd++;
        }
        static int retirar(int[] lista, int posicao, ref int qtd)
        {
            int n = lista[posicao];
            for (int i = posicao; i < qtd - 1; i++)
                lista[i] = lista[i + 1];
            qtd--;
            return n;
        }
        static int[] duplicar(int[] vet, int qtd, int qtd2)
        {
            int[] auxiliar= new int[qtd];
            int[] auxiliar2 = new int[qtd2];
            int n = qtd;

            for (int i = 0; i < qtd;)
            {
                int m = n - 1;
                acrescentar(auxiliar, i, ref i, retirar(vet, m, ref n));
            }

            n = qtd;

            for (int i = 0; i < qtd;)
            {
                int m = n - 1;
                acrescentar(auxiliar2, i, ref i, retirar(auxiliar, m, ref n));
            }

            n = qtd;

            for (int i = qtd; i < qtd2;)
            {
                int m = n - 1;
                acrescentar(auxiliar2, i, ref i, retirar(vet, m, ref n));
            }
            return auxiliar2;
        }
        static void Main(string[] args)
        {
            int[] lista = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 0, 0 };
            int qtd = 8;

            int qtd2 = 2 * qtd;
            int[] auxiliar= new int[qtd2];
            auxiliar= duplicar(lista, qtd, qtd2);

            Console.Write("A lista original é: ");
            for (int i = 0; i < qtd; i++)
                Console.Write(lista[i] + " ");
                Console.WriteLine();

            Console.Write("A lista duplicada + invertida é: ");
            for (int i = 0; i < qtd2; i++)
                Console.Write(auxiliar[i] + " ");
            Console.WriteLine();
        }
    }