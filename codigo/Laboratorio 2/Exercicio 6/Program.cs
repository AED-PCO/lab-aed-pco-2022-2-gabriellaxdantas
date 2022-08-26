//      Escreva um método recursivo que receba 
// uma frase e retorne a mesma frase, sem 
// nenhuma vogal. 

    string retornaSemVogal (string frase, int tamanho){
        int numVogais = 0;
            if (frase.Length == 0){
                return frase;
            }
            else if (tamanho == 0 && numVogais == 0){
                return frase;
            }
            else {
                string substitui = frase.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
                    numVogais++;
                    retornaSemVogal(substitui, tamanho-1);
                    return substitui;
            }
    }

    string frase, respt;
     Console.WriteLine("Informe a frase a ser retornada sem vogais:");
            frase = Console.ReadLine();
    int tamanho = frase.Length;

    respt = retornaSemVogal(frase, tamanho);
        Console.WriteLine(respt);

       
