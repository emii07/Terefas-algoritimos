void  Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}
void Subtração(float a, float b){
    float resultado = a - b;
    Console.WriteLine($" {a} - {b} = {resultado}");
}
void Multiplicação(float a , float b){
    float resultado = a * b;
    Console.WriteLine($"[a] * {b} = {resultado}");
}
void Divisão(float a , float b){
    if(b == 0){
        Console.WriteLine("erro de Divisao por zero");
        return;
    }
    float resultado = a /b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}
// variaveis globais 
float a;
float b;

void DigitarAeB(string operação){

    Console.WriteLine(operação);

    Console.WriteLine($"digite o valor de a");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine($"digite o valor de b");
    b = float.Parse(Console.ReadLine());
}
//MENU
Console.WriteLine("--- CALCULADORA ---");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Sair");
Console.WriteLine("----------------");
Console.WriteLine("digite a opção desejada:");

int opcão = int.Parse(Console.ReadLine());

if(opcão == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}
else if(opcão == 2){
     DigitarAeB("Subtração");
    Subtração(a,b);
}
else if(opcão == 3){
    DigitarAeB("Multiplicacão");
    Multiplicação(a,b);
}
else if(opcão == 4 ){
    DigitarAeB("Divisão");
    Divisão(a,b);
}
else if(opcão == 5){
    Console.WriteLine("saindo....");
}
else{
    Console.WriteLine("opcão inválida");
}