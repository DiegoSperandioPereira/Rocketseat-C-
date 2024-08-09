﻿using static System.Runtime.InteropServices.JavaScript.JSType;

bool exec = true;

while (exec)
{
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
        case "4":
            {
                NumberOfCharacters();
            }
            break;
        case "5":
            {
                ValidatePlate();
            }
            break;
        case "6":
            {
                ShowDate();
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
        double numberOne = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        double numberTwo = Convert.ToDouble(Console.ReadLine());

        double sum = numberOne + numberTwo;
        double subtraction = numberOne - numberTwo;
        double multiplication = numberOne * numberTwo;

        string error = string.Empty;
        double division = 0;

        if (numberTwo == 0)
        {
            error = "Não é possível dividir por zero";
        }
        else
        {
            division = numberOne / numberTwo;
        }

        double average = (numberOne + numberTwo) / 2;       

        Console.WriteLine("");
        Console.WriteLine("Soma: {0} + {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(sum));
        Console.WriteLine("Subtração: {0} - {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(subtraction));
        Console.WriteLine("Multiplicação: {0} * {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(multiplication));

        if (!string.IsNullOrEmpty(error))
            Console.WriteLine("Divisão: {0} / {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), error);
        else
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
        double subtraction = numberOne - numberTwo;
        double multiplication = numberOne * numberTwo;

        string error = string.Empty;
        double division = 0;

        if (numberTwo == 0)
        {
            error = "Não é possível dividir por zero";
        }
        else
        {
            division = numberOne / numberTwo;
        }

        double average = (numberOne + numberTwo) / 2;

        Console.WriteLine("");
        Console.WriteLine("Soma: {0} + {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(sum));
        Console.WriteLine("Subtração: {0} - {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(subtraction));
        Console.WriteLine("Multiplicação: {0} * {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), FormatNumber(multiplication));

        if (!string.IsNullOrEmpty(error))
            Console.WriteLine("Divisão: {0} / {1} = {2}", FormatNumber(numberOne), FormatNumber(numberTwo), error);
        else
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

    static void NumberOfCharacters()
    {
        Console.Write("\nDigite uma ou mais palavras (separadas por espaços): ");
        string input = Console.ReadLine();
        Console.WriteLine("");

        string[] palavras = input.Split(" ");

        foreach (string palavra in palavras)
        {
            if (!string.IsNullOrEmpty(palavra))
            {
                Console.WriteLine($"A palavra '{palavra}' tem {palavra.Length} caracteres.");
            }
        }
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
        bool isValid = true;

        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(plate[i]))
            {
                isValid = false;
                return false;
            }
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(plate[i]))
            {
                isValid = false;
                return false;
            }
        }

        return isValid;
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