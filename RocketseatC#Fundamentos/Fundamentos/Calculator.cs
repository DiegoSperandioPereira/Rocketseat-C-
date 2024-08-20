using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public static class Calculator
    {
        public static string Sum(double firstNumber, double secondNumber)
        {
            double sumResult = firstNumber + secondNumber;
            return $"Soma: {FormatNumber(firstNumber)} + {FormatNumber(secondNumber)} = {FormatNumber(sumResult)}";
        }

        public static string Subtraction(double firstNumber, double secondNumber)
        {
            double subtractionResult = firstNumber - secondNumber;
            return $"Subtração: {FormatNumber(firstNumber)} - {FormatNumber(secondNumber)} = {FormatNumber(subtractionResult)}";
        }

        public static string Multiplication(double firstNumber, double secondNumber)
        {
            double multiplicationResult = firstNumber * secondNumber;
            return $"Multiplicação: {FormatNumber(firstNumber)} * {FormatNumber(secondNumber)} = {FormatNumber(multiplicationResult)}";
        }

        public static string Division(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                return $"Divisão: {FormatNumber(firstNumber)} / {FormatNumber(secondNumber)} = Não é possível dividir por zero";
            }

            double divisionResult = firstNumber / secondNumber;
            return $"Divisão: {FormatNumber(firstNumber)} / {FormatNumber(secondNumber)} = {FormatNumber(divisionResult)}";
        }

        public static string Average(double firstNumber, double secondNumber)
        {
            double average = (firstNumber + secondNumber) / 2;
            return $"Média: ({FormatNumber(firstNumber)} + {FormatNumber(secondNumber)}) / 2 = {FormatNumber(average)}";
        }

        public static string GenerateRandom()
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

            // Construindo a string de resultado
            StringBuilder result = new StringBuilder();

            result.AppendLine();
            result.AppendLine($"Soma: {FormatNumber(numberOne)} + {FormatNumber(numberTwo)} = {FormatNumber(sum)}");
            result.AppendLine($"Subtração: {FormatNumber(numberOne)} - {FormatNumber(numberTwo)} = {FormatNumber(subtraction)}");
            result.AppendLine($"Multiplicação: {FormatNumber(numberOne)} * {FormatNumber(numberTwo)} = {FormatNumber(multiplication)}");

            if (!string.IsNullOrEmpty(error))
                result.AppendLine($"Divisão: {FormatNumber(numberOne)} / {FormatNumber(numberTwo)} = {error}");
            else
                result.AppendLine($"Divisão: {FormatNumber(numberOne)} / {FormatNumber(numberTwo)} = {FormatNumber(division)}");

            result.AppendLine($"Média: ({FormatNumber(numberOne)} + {FormatNumber(numberTwo)}) / 2 = {FormatNumber(average)}");

            return result.ToString();
        }

        static string FormatNumber(double number)
        {
            if (number == (int)number)
                return ((int)number).ToString("N0");
            else
                return number.ToString("F2");
        }
    }
}
