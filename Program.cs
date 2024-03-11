//1)
Console.WriteLine("Desafio 1: ");
int indice = 13, soma = 0, k = 0;
while (k < indice)
{
    k++;
    soma += k;
}

Console.WriteLine(soma);

Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine();


//2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos
//2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem
//que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem
//avisando se o número informado pertence ou não a sequência.
Console.WriteLine("Desafio 2: ");

Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
int numero = Convert.ToInt32(Console.ReadLine());

if (IsFibonacci(numero))
{
    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
}
    
static bool IsFibonacci(int num)
{
    int a = 0;
    int b = 1;
    int soma = 0;

    while (soma < num)
    {
        soma = a + b;
        a = b;
        b = soma;
    }

    return soma == num;
}

Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine();


//3) Descubra a lógica e complete o próximo elemento:

//a) 1, 3, 5, 7, 9    ( +2 )

//b) 2, 4, 8, 16, 32, 64, 128    (dobro do anterior)

//c) 0, 1, 4, 9, 16, 25, 36, 49     (numeros com raiz quadrada)    

//d) 4, 16, 36, 64, 100    (raiz quadrada de numeros pares)

//e) 1, 1, 2, 3, 5, 8, 13   (sequencia de fibonacci)

//f) 2,10, 12, 16, 17, 18, 19, 200    (numeros que começam com a letra D)

Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine();

//4) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente.
//Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas
//vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.
//Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor
//controla cada lâmpada?

//RESPOSTA: Ligaria o interruptore, esperaria 2 minutos, desligaria e iria até a lâmpada  e veria qual estava 
//quente, assim descobriria que seu interruptor era aquele que tinha ligado. 

Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine();

//5) Escreva um programa que inverta os caracteres de um string:
Console.WriteLine("Desafio 5: ");

Console.WriteLine("Digite uma string para inverter:");
string input = Console.ReadLine();

string reversed = ReverseString(input);

Console.WriteLine("String invertida: " + reversed);

    static string ReverseString(string str)
{
    string reversed = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        reversed += str[i];
    }
    return reversed;
}

