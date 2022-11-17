 class pilha
    {
        private celula primeiro;
        public pilha()
        {
            primeiro = null;
        }
        public void acrescentar(string num){
            celula aux = new celula(num);
            aux.apontador = primeiro;
            primeiro = aux;
            aux = null;
        }
        public string remover(){
            if (primeiro == null){
                Console.WriteLine("A pilha se econtra vazia.");
                return "";
            }
            string sair = primeiro.val;     
            celula aux = primeiro;            
            primeiro = primeiro.apontador;    
            aux.apontador = null;              
            aux = null;              
            return sair;                       
        }
        public void imprime(){
            Console.Write("PILHA: ");
            imprime(primeiro);
            Console.WriteLine();
            Console.ResetColor();
        }
        private void imprime(celula primeiro){
            if (primeiro != null){
                imprime(primeiro.apontador);
                Console.Write("{0} ", primeiro.val);
            }
        }
    }