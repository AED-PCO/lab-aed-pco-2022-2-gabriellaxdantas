 class celula
    {
        public string val;
        public celula apontador;
        public celula(){
            val = "";
            apontador = null;
        }
        public celula(string val){
            this.val = val;
            apontador = null;
        }
    }