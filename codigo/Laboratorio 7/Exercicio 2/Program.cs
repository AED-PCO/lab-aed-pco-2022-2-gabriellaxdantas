int funcRec1 (int a){
    if (a<=1){
        return 0;
    }
    else {
        return funcRec1((a-2) + 5);
    }
}


int a = 6;
int res = funcRec1(a);
Console.WriteLine(res);