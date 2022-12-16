  class Listas
    {
        private celula primeiro, ultimo;
        public Listas()
        {
            primeiro = new celula();
            ultimo = primeiro;
        }
        public int tam()
        {
            int aux = 0;
            for (celula i = primeiro; i != ultimo; i = i.frente)
            {
                aux++;
            }
            return aux;
        }
        public void adicionar(string num)
        {
            ultimo.frente = new celula(num);
            ultimo.frente.tras = ultimo;
            ultimo = ultimo.frente;
        }
        public void adicionar(string num, int pos)
        {
            int tamanho = tam();
            pos--;
            if (pos < 0 || pos > tamanho)
            {
                Console.WriteLine("O valor informado é invalido");
            }
            else if (pos == 0) 
            {
                celula aux = new celula(num);
                aux.tras = primeiro;
                aux.frente = primeiro.frente;
                primeiro.frente = aux;
                if (primeiro == ultimo)
                {
                    ultimo = aux;
                }
                else
                {
                    aux.frente.tras = aux;
                }
                aux = null;
            }
            else if (pos == tamanho) 
            {
                adicionar(num);
            }
            else
            {
                celula aux = primeiro;
                for (int i = 0; i < pos; i++)
                {
                    aux = aux.frente;
                }
                celula aux2 = new celula(num);
                aux2.tras = aux;
                aux2.frente = aux.frente;
                aux2.tras.frente = aux2;
                aux2.frente.tras = aux2;
                aux = null;
                aux2 = null;
            }
        }
        public int remover()
        {
            if (primeiro == ultimo)
                return -1;
            else
                return 0;
        }
        public string remover(string num)
        {
            int pos = busca(num);
            if (pos < 0)
            {
                Console.WriteLine("Elemento não localizado");
                return "";
            }
            else if (pos == 0) // Remover Início
            {
                celula aux = primeiro;
                primeiro = primeiro.frente;
                string sair = primeiro.valor;
                primeiro.tras = null;
                aux.frente = null;
                aux = null;
                return sair;
            }
            else if (pos == (tam() - 1)) // Remover Fim
            {
                string sair = ultimo.valor;
                ultimo = ultimo.tras;
                ultimo.frente.tras = null;
                ultimo.frente = null;
                return sair;
            }
            else
            {
                celula aux = primeiro.frente;
                for (int i = 0; i < pos; i++)
                {
                    aux = aux.frente;
                }
                aux.tras.frente = aux.frente;
                aux.frente.tras = aux.tras;
                string sair = aux.valor;
                aux.frente = null;
                aux.tras = null;
                aux = null;
                return sair;
            }  
        }
        private int busca(string num)
        {
            int aux = 0;
            for (celula i = primeiro.frente; i != null; i = i.frente)
            {
                if (num == i.valor)
                {
                    return aux;
                }
                aux++;
            }
            return -1;
        }
        public void imprimi()
        {
            Console.Write("Os elemntos da lista são: ");

            for (celula i = primeiro.frente; i != null; i = i.frente)
                Console.Write("{0} ", i.valor);

            Console.WriteLine();
        }
    }