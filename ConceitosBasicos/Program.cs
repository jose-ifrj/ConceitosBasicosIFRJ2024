// crie um programa para calcular o IMC de uma pessoa e informar o status de acordo com o imc calculado
//

int opcao = 0;

do
{
    
    Console.WriteLine("Informe o que deseja fazer:");
    Console.WriteLine("(1) Calcular IMC");
    Console.WriteLine("(0) Encerrar");
    opcao = Convert.ToInt32(Console.ReadLine());
    if (opcao == 1)
        CalcularIMC();

} while (opcao != 0);
Console.WriteLine("Obrigado por sua participação!");
Console.WriteLine("Programa Finalizado.");

// modifique o programa para que possua um menu de opções para suas funcionalidades

using System.Globalization;

int opcao = 0;

do
{
    Console.WriteLine("Informe o que deseja fazer:");
    Console.WriteLine("(1) Calcular IMC");
    Console.WriteLine("(2) Peso Ideal");
    Console.WriteLine("(3) Jogo de adivinhação");
    Console.WriteLine("(4) Ordenar Valores");
    Console.WriteLine("(0) Encerrar");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            CalcularIMC();
            break;
        case 2:
            PesoIdeal();
            break;
        case 3:
            JogoAdivinhacao();
            break;
        case 4:
            OrdenarValores();
            break;
    }
    /*
    if (opcao == 1)
        CalcularIMC();
    else if (opcao == 2)
        PesoIdeal();
    else if (opcao == 3)
        JogoAdivinhacao();
    */
} while (opcao != 0);
Console.WriteLine("Obrigado por sua participação!");
Console.WriteLine("Programa Finalizado");

static void CalcularIMC()
{
    Console.WriteLine("Informe seu peso:");
    int peso = int.Parse(Console.ReadLine());

Console.WriteLine("Informe sua altura:");
float altura = float.Parse(Console.ReadLine());

    float imc = peso / (altura * altura);

    Console.WriteLine($"Para o peso {peso} e a altura {altura} o imc calculado foi {imc:f1}");

string status = string.Empty;
if (imc <= 16.9)
    status = "muito abaixo do peso";
else if (imc <= 18.4)
    status = "abaixo do peso";
