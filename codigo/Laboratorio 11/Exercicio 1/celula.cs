 class celula
    {
        public string valor;
        public celula frente, tras;
        public celula()
        {
            valor = "";
            frente = null;
            tras = null;
        }
        public celula(string valor)
        {
            this.valor = valor;
            frente = null;
            tras = null;
        }
    }