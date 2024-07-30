bool exec = true;

while (exec)
{
    Console.WriteLine("\n--------------- MENU ---------------");
    Console.WriteLine("1 - Nome e mensagem personalizada");
    Console.WriteLine("2 - Nome e Sobrenome");
    Console.WriteLine("3 - Soma, subtração, multiplicação, divisão e média ");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("-------------------------------------");

    Console.Write("\nInforme o código da opção desejada: ");
    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            {
                NameWithMessageCustom();
            }
            break;
        case "2":
            {
                NameAndSurname();
            }
            break;
        case "3":
            {
                Operations();
            }
            break;
        case "5":
            {
                exec = false;
                Console.WriteLine("Volte sempre!!");
            }
            break;
        default:
            {
                Console.WriteLine("");
                Console.WriteLine("Opção informada não existe!");
                Console.WriteLine("");
                Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
                Console.ReadKey();
            }
            break;
    }

    static void NameWithMessageCustom()
    {
        Console.Write("\nInforme seu nome: ");
        var name = Console.ReadLine();

        Console.Write("Informe sua mensagem de boas vindas: ");
        var message = Console.ReadLine();

        var result = string.Format("Olá, {0}! {1}", name, message);

        Console.WriteLine("\n" + result);
        Console.WriteLine("");
        Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
        Console.ReadKey();
    }

    static void NameAndSurname()
    {
        Console.Write("\nInforme seu nome: ");
        var name = Console.ReadLine();

        Console.Write("Informe seu sobrenome: ");
        var surname = Console.ReadLine();

        var result = string.Format("{0} {1}", name, surname);

        Console.WriteLine("\n" + result);
        Console.WriteLine("");
        Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
        Console.ReadKey();
    }

    static void Operations()
    {
        Console.WriteLine("");
        Console.WriteLine("1 - Inserir números");
        Console.WriteLine("2 - Gerar números aleatórios");
        Console.Write("\nInforme a opção desejada: ");

        var options = Convert.ToInt32(Console.ReadLine());

        if (options == 1)
            ReportNumbers();
        else if (options == 2)
            GenerateNumbers();
        else
            Console.Write("\nOpção não encontrada.");

    }

    static void ReportNumbers()
    {
        Console.Write("\nDigite o primeiro numero: ");
        var numberOne = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        var numberTwo = Convert.ToDouble(Console.ReadLine());

        var sum = numberOne + numberTwo;
        var multiplication = numberOne * numberTwo;
        var division = numberOne / numberTwo;
        var average = (numberOne + numberTwo) / 2;

        Console.WriteLine("");
        Console.WriteLine("Soma: {0} + {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(sum));
        Console.WriteLine("Multiplicação: {0} * {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(multiplication));
        Console.WriteLine("Divisão: {0} / {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(division));
        Console.WriteLine("Média: ({0} + {1}) / 2 = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(average));
        Console.WriteLine("");
        Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
        Console.ReadKey();
    }

    static void GenerateNumbers()
    {
        Random random = new();

        double numberOne = random.Next(1, 1000);
        double numberTwo = random.Next(1, 1000);

        double sum = numberOne + numberTwo;
        double multiplication = numberOne * numberTwo;
        double division = numberOne / numberTwo;
        double average = (numberOne + numberTwo) / 2;

        Console.WriteLine("");
        Console.WriteLine("Soma: {0} + {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(sum));
        Console.WriteLine("Multiplicação: {0} * {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(multiplication));
        Console.WriteLine("Divisão: {0} / {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(division));
        Console.WriteLine("Média: ({0} + {1}) / 2 = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(average));
        Console.WriteLine("");
        Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
        Console.ReadKey();
    }

    static string FormatNumber(double number)
    {
        if (number == (int)number)
            return ((int)number).ToString("N0");
        else
            return number.ToString("F2");
    }
}