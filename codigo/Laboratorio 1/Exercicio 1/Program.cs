
// Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
// esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
// é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
// Número = 3025 
// Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
// A soma de 30 com 25 é igual a 55
// O Quadrado de 55 é igual a 3025.
 
// Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica:

int i, resto=0, quociente=0;
    for(i=1000; i<=9999; i++){
        quociente=i/100;
        resto=i%100;
        if((quociente+resto)*(quociente+resto)==i){
            Console.WriteLine(i);
        }
    }
