 class Program
    {
        static void acrescentar(int[] pilha, ref int qtd, int n)
        {
            pilha[qtd] = n;
            qtd++;
        }
        static int retirar(int[] pilha, ref int qtd)
        {
            qtd--;
            return pilha[qtd];
        }

        static void imprimir(int[] vetor, int qtd)
        {
            Console.Write("Os valores presentes na pilha são: ");
            for (int i = 0; i < qtd; i++)
                Console.Write(vetor[i] + " ");
                Console.WriteLine();
        }
         static void imprimir2(int[] vetor, int qtd)
        {
            Console.Write("Os valores presentes na pilha copiada são: ");
            for (int i = 0; i < qtd; i++)
                Console.Write(vetor[i] + " ");
                Console.WriteLine();
        }
        static int[] copiar(int[] vetor, int qtd)
        {
            int[] auxiliar= new int[qtd];
            int[] auxiliar2 = new int[qtd];
            int n = qtd;

            for (int i = 0; i < qtd;)
                acrescentar(auxiliar, ref i, retirar(vetor, ref n));

            n = qtd;

            for (int i = 0; i < qtd;)
                acrescentar(auxiliar2, ref i, retirar(auxiliar, ref n));

            return auxiliar2;
        }
        static void Main(string[] args)
        {
            int[] pilha = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 0, 0 };
            int qtd = 8;

            int[] auxiliar= new int[qtd];
            auxiliar= copiar(pilha, qtd);
            
            imprimir(pilha, qtd);
            imprimir2(auxiliar, qtd);
        }
    }