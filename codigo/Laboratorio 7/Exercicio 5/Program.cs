int funcao (int a, int [] vetor){
    if (a == 1){
        return vetor[0];
    }
    else {
        int x;
        x = funcao(a-1, vetor);
        if (x > vetor[a-1]){
            return x;
        }
        else 
        return vetor[ a-1];
    }
}

int [] vetor = new int [7] {10, 5, 7, 15, 22, 9, 30};
int a = 6;
int res = funcao(a, vetor);
Console.WriteLine(res);