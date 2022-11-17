    class fila
    {
        private celula primeiro, ultimo;      
        public fila()                          
        {
            primeiro = new celula();           
            ultimo = primeiro;                 
        }
        public void acrescentar(string num)        
        {
            ultimo.apontador = new celula(num); 
            ultimo = ultimo.apontador;          
        }
        public string remover(){
            if (primeiro == ultimo){
                Console.WriteLine("A fila está vazia.");
                return "";
            }
            celula aux = primeiro;              
            primeiro = primeiro.apontador;       
            string fim = primeiro.val;        
            aux.apontador = null;               
            aux = null;                         
            return fim;                         
        }
        public void imprime(){
            Console.Write("FILA: ");
            for (celula i = primeiro.apontador; i != null; i = i.apontador) 
                Console.Write("{0}  ", i.val); 
                Console.WriteLine();
            }
        }
