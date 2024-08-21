Console.WriteLine("Bem-vindo à Calculadora!");

Console.WriteLine("Digite o primeiro número:");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha a operação que deseja realizar:");
Console.WriteLine("1- Adição (+)");
Console.WriteLine("2- Subtração (-)");
Console.WriteLine("3- Multiplicação (*)");
Console.WriteLine("4- Divisão (/)");
string opcao = Console.ReadLine();

double resultado = 0;

switch (opcao)
{
    case "1":
        resultado = numero1 + numero2;
        Console.WriteLine("Resultado: " + numero1 + " + " + numero2 + " = " + resultado);
        break;

    case "2":
        resultado = numero1 - numero2;
        Console.WriteLine("Resultado: " + numero1 + " - " + numero2 + " = " + resultado);
        break;

    case "3":
        resultado = numero1 * numero2;
        Console.WriteLine("Resultado: " + numero1 + " * " + numero2 + " = " + resultado);
        break;

    case "4":
        if (numero2 != 0)
        {
            resultado = numero1 / numero2;
            Console.WriteLine("Resultado: " + numero1 + " / " + numero2 + " = " + resultado);
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }
        break;

    default:
        Console.WriteLine("Operação inválida.");
        break;
}

Console.WriteLine("Obrigado por usar a Calculadora!");
