using Calculadora.Models;

Operacoes calc = new Operacoes();
double x = 0, y = 0;
string operacao;

Console.WriteLine ("Digite o primeiro numero: ");
x = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("\nSelecione a operação desejada: \n 1(+) --> Soma\n 2(-) --> Subtração\n 3(/) --> Divisão\n 4(*) --> Multiplicação\n 5(^) --> Potência\n 6 --> Funções Trigonométricas\n 7 --> Raiz Quadrada \n\n\n 0 --> Sair");
operacao = Console.ReadLine();

switch (operacao){
    case "1" or "+":
    Console.WriteLine ("\nDigite o segundo numero: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Somar(x, y);
    break;

    case "2" or "-":
    Console.WriteLine ("\nDigite o segundo numero: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Subtrair(x, y);
    break;

    case "3" or "*":
    Console.WriteLine ("\nDigite o segundo numero: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Multiplicar(x, y);
    break;

    case "4" or "/":
    Console.WriteLine ("\nDigite o segundo numero: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Dividir(x, y);
    break;

    case "5" or "^":
    Console.WriteLine ("\nDigite o expoente: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Potencia(x, y);
    break;

    case "6":
    int opcTrigonometrica;

    Console.WriteLine("Selecione a operção Trigonométrica: \n 1 - Seno\n 2 - Coseno\n 3 - Tangente");
    opcTrigonometrica = Convert.ToInt32(Console.ReadLine());
        if (opcTrigonometrica == 1){
            calc.Seno(x);
        }
        else if(opcTrigonometrica == 2){
            calc.Coseno(x);
        }
        else if (opcTrigonometrica == 3){
            calc.Tangente(x);
        }
    break;

    case "7":
    calc.RaizQuadrada(x);
    break;

    case "0":
    Console.WriteLine("Obrigado, até mais!");
    Console.WriteLine("Encerrando...");
    Environment.Exit(0); 
    break;

    default:
    Console.WriteLine($"Operação '{operacao}' não pode ser encontrada!");
    break;
}
