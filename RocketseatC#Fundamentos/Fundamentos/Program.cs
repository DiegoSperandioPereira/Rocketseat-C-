using Fundamentos;

bool exec = true;

while (exec)
{

    Console.Clear(); // Limpa o console antes de exibir o menu novamente 
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("---------------- MENU ---------------");
    Console.WriteLine("1 - Nome e mensagem personalizada");
    Console.WriteLine("2 - Nome e Sobrenome");
    Console.WriteLine("3 - Soma, subtração, multiplicação, divisão e média ");
    Console.WriteLine("4 - Retornar quantidade de caracter");
    Console.WriteLine("5 - Retornar se a placa é valida");
    Console.WriteLine("6 - Exibir data em diferentes formatos");
    Console.WriteLine("7 - Sair");
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("-------------------------------------");

    Console.Write("\nInforme o código da opção desejada: ");
    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            {
                NameWithMessageCustom();
                Console.WriteLine("");
                Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
                Console.ReadKey();
            }
            break;
        case "2":
            {
                NameAndSurname();
                Console.WriteLine("");
                Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
                Console.ReadKey();
            }
            break;
        case "3":
            {
                Operations();
                Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
                Console.ReadKey();
            }
            break;
        case "4":
            {
                NumberOfCharacters();
                Console.WriteLine("");
                Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
                Console.ReadKey();
            }
            break;
        case "5":
            {
                ValidatePlate();
                Console.WriteLine("");
                Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
                Console.ReadKey();
            }
            break;
        case "6":
            {
                ShowDate();
                Console.WriteLine("");
                Console.WriteLine("Precione qualquer tecla para voltar para o menu.");
                Console.ReadKey();
            }
            break;
        case "7":
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
    }

    static void NameAndSurname()
    {
        Console.Write("\nInforme seu primeiro nome: ");
        var name = Console.ReadLine();

        Console.Write("Informe seu sobrenome: ");
        var surname = Console.ReadLine();

        var result = string.Format("{0} {1}", name, surname);

        Console.WriteLine("\n" + result);
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
        double numberOne = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        double numberTwo = Convert.ToDouble(Console.ReadLine());

        var sum = Calculator.Sum(numberOne, numberTwo);
        var subtraction = Calculator.Subtraction(numberOne, numberTwo);
        var multiplication = Calculator.Multiplication(numberOne, numberTwo);
        var division = Calculator.Division(numberOne, numberTwo);
        var average = Calculator.Average(numberOne, numberTwo);

        Console.WriteLine("");
        Console.WriteLine(sum);
        Console.WriteLine(subtraction);
        Console.WriteLine(multiplication);
        Console.WriteLine(division);
        Console.WriteLine(average);
    }

    static void GenerateNumbers()
    {
        Console.WriteLine(Calculator.GenerateRandom());
    }

    static void NumberOfCharacters()
    {
        Console.Write("\nDigite uma ou mais palavras (separadas por espaços): ");
        string input = Console.ReadLine();
        Console.WriteLine("");

        string[] palavras = input.Split(" ");
        int total = 0;

        foreach (string palavra in palavras)
        {
            if (!string.IsNullOrEmpty(palavra))
            {
                Console.WriteLine($"A palavra '{palavra}' tem {palavra.Length} caracteres.");
                total += palavra.Length;
            }
        }

        Console.WriteLine("\nTotal de caracters: {0}", total);
    }

    static void ValidatePlate()
    {
        Console.Write("\nDigite o numero da placa: ");
        string plate = Console.ReadLine();
        Console.WriteLine("");

        if (!string.IsNullOrEmpty(plate) && plate.Length == 7)
        {
            if (IsValidPlate(plate))
            {
                Console.WriteLine("Verdadeiro, a placa é valida!");
            }
            else
            {
                Console.WriteLine("Falso, a placa é invalida!");
            }
        }
        else
        {
            Console.WriteLine("Falso, a placa é invalida!");
        }
    }

    static bool IsValidPlate(string plate)
    {
        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(plate[i]))
            {
                return false;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(plate[i]))
            {
                return false;
            }
        }

        return true;
    }

    static void ShowDate()
    {
        Console.Write("\nFormato completo: ");
        Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        Console.Write("Apenas a data: ");
        Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        Console.Write("Apenas a hora: ");
        Console.WriteLine(DateTime.Now.ToString("HH:mm"));
        Console.Write("Data com o mês por extenso: ");
        Console.WriteLine(DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}