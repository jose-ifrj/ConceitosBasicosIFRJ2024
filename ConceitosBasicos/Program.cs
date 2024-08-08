// crie um programa para calcular o IMC de uma pessoa e informar o status de acordo com o imc calculado

// modifique o programa para que possua um menu de opções para suas funcionalidades

using System.ComponentModel.Design;
using System.Globalization;

int opcao = 0;

do
{
    Console.WriteLine("Informe o que deseja fazer:");
    Console.WriteLine("(1) Calcular IMC");
    Console.WriteLine("(2) Peso Ideal");
    Console.WriteLine("(3) Jogo de adivinhação");
    Console.WriteLine("(4) Ordenar Valores");
    Console.WriteLine("(5) Verificar Número Primo");
    Console.WriteLine("(6) Número Fatorial");
    Console.WriteLine("(7) Área do Retângulo");
    Console.WriteLine("(8) Área do Triângulo");
    Console.WriteLine("(9) Área da Circunferência");

    Console.WriteLine("\n(0) Encerrar");
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
        case 5:
            VerificarNumeroPrimo();
            break;
        case 6:
            fatorial();
            break;
        case 7:
            areaRetangulo();
            break;
        case 8:
            areaTriangulo();
            break;
        case 9:
            areaCircunferencia();
            break;
    }

} while (opcao != 0);
Console.WriteLine("Obrigado por sua participação!");
Console.WriteLine("Programa Finalizado");

static void CalcularIMC()
{
    Console.WriteLine("Informe seu peso:");
    int peso = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe sua altura:");
    float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    float imc = peso / (altura * altura);

    Console.WriteLine($"Para o peso {peso} e a altura {altura} o imc calculado foi {imc:f1}");

    string status = string.Empty;
    if (imc <= 16.9)
        status = "muito abaixo do peso";
    else if (imc <= 18.4)
        status = "magreza";
    else if (imc <= 24.9)
        status = "normal";
    else if (imc <= 29.9)
        status = "Sobrepeso";
    else if (imc <= 39.9)
        status = "Obesidade";
    else
        status = "Obesidade Grave";

    // crie a mensagem: O IMC x indica a classificação y
    // $ -> caractere de interpolação
    Console.WriteLine($"O IMC {imc} indica a classificação {status}");
    Console.Write("Aperte Enter para continuar!");
    ConsoleKeyInfo c;
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
}

static void PesoIdeal()
{
    Console.WriteLine("Informe sua altura:");
    float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    float minIdeal = (float)(Math.Pow(altura, 2) * 18.5);
    float maxIdeal = (float)(Math.Pow(altura, 2) * 24.9);
    Console.WriteLine($"Pelo IMC, o peso ideal de uma pessoa que mede {altura*100}cm");
    Console.WriteLine($" fica entre {minIdeal:f1} e {maxIdeal:f1}");
    Console.Write("Aperte Enter para continuar!");
    ConsoleKeyInfo c;
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
}

static void JogoAdivinhacao()
{
    Console.WriteLine("você tem 10 tentativas para adivinhar um número entre 1 e 100!");
    Random random = new Random();
    int valorSorteado = random.Next(1, 100);
    int tentativa;
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{i + 1}a. tentativa:");
        tentativa = Convert.ToInt32(Console.ReadLine());
        if (tentativa == valorSorteado)
        {
            Console.WriteLine($"Parabéns!! Você adivinhou o número em {i} tentativas!!!");
            break;
        }
        if (i < 9)
        {
            if (tentativa < valorSorteado)
                Console.WriteLine("O valor sorteado é maior que o número informado. Tente novamente!");
            else if (tentativa > valorSorteado)
                Console.WriteLine("O valor sorteado é menor que o número informado. Tente novamente!");
        }
        else
        {
            Console.WriteLine("Você não possui mais tentativas!");
        }

    }
    Console.WriteLine("Fim de Jogo!");
    Console.Write("Aperte Enter para continuar!");
    ConsoleKeyInfo c;
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
}

static void OrdenarValores()
{
    int tamanho = 5;
    int[] valores = new int[tamanho];
    int[] ordenado = new int[tamanho];

    for (int i = 0; i < valores.Length; i++)
    {
        Console.WriteLine("Informe o {0}o. valor ", i + 1);
        valores[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = valores.Length; i > 1; i--)
    {
        for (int j = i - 1; j <= 4; j++)
        {
            if (valores[j - 1] < valores[j])
            {
                var temp = valores[j - 1];
                valores[j - 1] = valores[j];
                valores[j] = temp;
            }
        }
    }

    Console.WriteLine("Valores Informados:");
    foreach (var valor in valores)
    {
        Console.WriteLine(valor + " ");
    }

    Console.Write("Aperte Enter para continuar!");
    ConsoleKeyInfo c;
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
}

static void VerificarNumeroPrimo()
{
    Console.WriteLine("Informe um número inteiro:");
    int numero = Convert.ToInt32(Console.ReadLine());
    bool primo = true;
    ConsoleKeyInfo c;
    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
        {
            Console.WriteLine("O número informado não é primo!");
            Console.Write("Aperte Enter para continuar!");
            
            do
            {
                c = Console.ReadKey();
            } while (c.Key != ConsoleKey.Enter);
            Console.Clear();
            return;
        }
    }
    Console.WriteLine("O número informado é primo!");
    Console.Write("Aperte Enter para continuar!");
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
    return;
        
    
}

static void areaRetangulo()
{
    Console.WriteLine("Insira a Altura do Retângulo em metros: ");
    int altura = Int32.Parse(Console.ReadLine());
    Console.WriteLine("\nInsira a Largura do Retângulo em metros: ");
    int largura = Int32.Parse(Console.ReadLine());

    Console.WriteLine("A área do retângulo é: {0}m²", altura*largura);
    Console.Write("Aperte Enter para continuar!");
    ConsoleKeyInfo c;
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
}

static void areaTriangulo()
{
    ConsoleKeyInfo c;
    Console.WriteLine("Insira um lado do Triângulo em metros: ");
    int lado1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("\nInsira outro lado do Triângulo em metros: ");
    int lado2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("\nInsira o terceiro lado do Triângulo em metros: ");
    int lado3 = Int32.Parse(Console.ReadLine());

    bool lado1maior = lado1 > lado2 && lado1 > lado3;
    bool lado2maior = lado2 > lado1 && lado2 > lado3;
    bool lado3maior = lado3 > lado1 && lado3 > lado2;

    bool triangulo = true;

    if (lado1maior && lado2 + lado3 <= lado1)
    {
        // caso o lado 1 for maior, e a soma dos outros dois serem maiores:
        triangulo = false;
    };
    if (lado2maior && lado1 + lado3 <= lado2)
    {
        // caso o lado 2 for maior, e a soma dos outros dois serem maiores:
        triangulo = false;
    };
    if (lado3maior && lado1 + lado2 <= lado3)
    {
        // caso o lado 3 for maior, e a soma dos outros dois serem maiores:
        triangulo = false;
    };

    if(triangulo == false)
    {
        Console.WriteLine("Algum lado é pequeno demais para formar um triângulo!");
        Console.Write("Aperte Enter para continuar!");
        do
        {
            c = Console.ReadKey();
        } while (c.Key != ConsoleKey.Enter);
        Console.Clear();
        return;
    }

    double semiperimetro = (lado1 + lado2 + lado3)/2;

    Console.WriteLine("A área do Triângulo é: {0}m²", Math.Sqrt((semiperimetro * (semiperimetro - lado1)*(semiperimetro - lado2)*(semiperimetro - lado3))));
    Console.Write("Aperte Enter para continuar!");
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
}

static void areaCircunferencia()
{
    Console.WriteLine("Insira o Raio da Circunferência em metros: ");
    int raio = Int32.Parse(Console.ReadLine());

    Console.WriteLine("A área da Circunferência é: {0}m²", Math.PI * Math.Pow(raio, 2));
    Console.Write("Aperte Enter para continuar!");
    ConsoleKeyInfo c;
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
}

static void fatorial()
{
    Console.WriteLine("Insira um número");
    int numero = Int32.Parse(Console.ReadLine());
    int fatorial = 1;

    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i;
    }

    Console.WriteLine("O fatorial de {0} é {1}", numero, fatorial);
    Console.Write("Aperte Enter para continuar!");
    ConsoleKeyInfo c;
    do
    {
        c = Console.ReadKey();
    } while (c.Key != ConsoleKey.Enter);
    Console.Clear();
}