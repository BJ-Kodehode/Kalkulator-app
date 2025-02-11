using System;

class Program
{
    static void Main()
    {
        ICalculator calculator = new Calculator();

        double num1 = GetValidNumber("Enter first number:");
        double num2 = GetValidNumber("Enter second number:");

        Console.WriteLine("Enter operator (+, -, *, /):");
        string? op = Console.ReadLine();

        // Sikre at operatøren ikke er null eller tom
        while (string.IsNullOrWhiteSpace(op) || !" +-*/".Contains(op))
        {
            Console.WriteLine("Invalid operator! Please enter +, -, * or /:");
            op = Console.ReadLine();
        }

        double result = 0;

        switch (op)
        {
            case "+":
                result = calculator.AddNumbers(num1, num2);
                break;
            case "-":
                result = calculator.SubtractNumbers(num1, num2);
                break;
            case "*":
                result = calculator.MultiplyNumbers(num1, num2);
                break;
            case "/":
                result = calculator.DivideNumbers(num1, num2);
                break;
        }

        Console.WriteLine($"Result: {result}");
    }

    /// <summary>
    /// Hjelpemetode for å få et gyldig tall fra brukeren.
    /// </summary>
    /// <param name="message">Meldingen som vises til brukeren</param>
    /// <returns>Et gyldig dobbeltall</returns>
    static double GetValidNumber(string message)
    {
        double number;
        while (true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input) && double.TryParse(input, out number))
            {
                return number;
            }

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
