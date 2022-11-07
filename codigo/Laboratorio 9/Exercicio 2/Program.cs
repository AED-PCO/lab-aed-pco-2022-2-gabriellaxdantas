 class Program
    {
        static void acrescentar(int[] fila, ref int qtd, int n)
        {
            fila[qtd] = n;
            qtd++;
        }
        static int retirar(int[] fila, ref int qtd)
        {
            int n = fila[0];
            for (int i = 0; i < qtd - 1; i++)
                fila[i] = fila[i + 1];
            qtd--;
            return n;
        }

        static void imprime(int[] vetor, int qtd)
        {
            Console.Write("A fila original é: ");
            for (int i = 0; i < qtd; i++)
                Console.Write(vetor[i] + " ");
                Console.WriteLine();
        }
         static void imprime2(int[] vetor, int qtd)
        {
            Console.Write("A fila invertida é: ");
            for (int i = 0; i < qtd; i++)
                Console.Write(vetor[i] + " ");
                Console.WriteLine();
        }
        static int[] inverte(int[] vetor, int qtd)
        {
            int[] pilha = new int[qtd];
            int[] auxiliar = new int[qtd];
            int n = qtd;

            for (int i = 0; i < qtd;)
                acrescentar(pilha, ref i, retirar(vetor, ref n));

            for (int i = 0; i < qtd;)
                acrescentar(vetor, ref i, pilha[i]);

            n = qtd;

            for (int i = 0; i < qtd;)
                acrescentar(auxiliar, ref i, retirarPilha(pilha, ref n));

            return auxiliar;
        }
        static int retirarPilha(int[] pilha, ref int qtd)
        {
            qtd--;
            return pilha[qtd];
        }
        static void Main(string[] args)
        {
            int[] fila = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 0, 0 };
            int qtd = 8;

            int[] auxiliar = new int[qtd];
            auxiliar = inverte(fila, qtd);
            
            imprime(fila, qtd);
            imprime2(auxiliar, qtd);
        }
    }