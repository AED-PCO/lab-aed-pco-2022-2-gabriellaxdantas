int iguais = 0, diferentes = 0;
Console.WriteLine("Informe um texto para realizarmos a comparação:");
string texto = Console.ReadLine();
string[] valores = texto.Split(" ");
StreamReader ler = new StreamReader("../Arquivos/arquivo1.txt");
string linha = ler.ReadLine();
    while (linha != null){
        string[] palavras = linha.Split(" ");
            for (int i = 0; i < valores.Length; i++)
                for (int j = 0; j < palavras.Length; j++)
                    if (palavras[j] == valores[i])
                    iguais++;
                    diferentes += palavras.Length;
                    linha = ler.ReadLine();
        }
        ler.Close();
            
Console.WriteLine("Os textos apresentam: {0} termos iguais", iguais);
Console.WriteLine("Os textos apresentam: {0} termos diferentes", diferentes - iguais);
