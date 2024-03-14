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
        status = "magreza";
    else if (imc <= 29.9)
        status = "Sobrepeso";
    else if (imc <= 39.9)
        status = "Obesidade";
    else
        status = "Obesidade Grave";

    Console.WriteLine($"O IMC {imc} indica a classificação {status}");
}
