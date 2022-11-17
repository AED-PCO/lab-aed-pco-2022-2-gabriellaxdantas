  class lista
    {
        private celula primeiro, ultimo;
        public lista(){
            primeiro = new celula();
            ultimo = primeiro;
        }
        public int tamanho(){
            int aux = 0;
            for (celula i = primeiro; i != ultimo; i = i.apontador){
                aux++;
            }
            return aux;
        }
        public void acrescentar(string num){
            ultimo.apontador = new celula(num);
            ultimo = ultimo.apontador;
        }
        public void acrescentar(string num, int posicao){
            posicao--;
            if (posicao < 0 || posicao > tamanho()){
                Console.WriteLine("O valor informado é invalido.");
            }
            else{
                celula aux = primeiro;
                for (int i = 0; i < posicao; i++){
                    aux = aux.apontador;
                }
                celula aux2 = new celula(num);
                aux2.apontador = aux.apontador;
                aux.apontador = aux2;
                aux = null;
                aux2 = null;
            }
        }
        public int remover(){
            if (primeiro == ultimo)
                return -1;
            else
                return 0;
        }
        public string remover(string num){
            int posicao = busca(num);
            if (posicao < 0){
                Console.WriteLine("O valor informado não foi encontrado.");
                return "";
            }
            else{
                celula aux = primeiro;
                for (int i = 0; i < posicao; i++){
                    aux = aux.apontador;
                }
                celula aux2 = aux.apontador;
                string sair = aux2.val;
                aux.apontador = aux2.apontador;
                aux2.apontador = null;
                aux = null;
                aux2 = null;
                return sair;
            }  
        }
        private int busca(string num){
            int aux = 0;
            for (celula i = primeiro.apontador; i != null; i = i.apontador){
                if (num == i.val){
                    return aux; 
                }
                aux++;
            }
            return -1;
        }
        public void imprime(){
            Console.Write("LISTA: ");

            for (celula i = primeiro.apontador; i != null; i = i.apontador){
                Console.Write("{0} ", i.val);
            }
            Console.WriteLine();
        }
    }