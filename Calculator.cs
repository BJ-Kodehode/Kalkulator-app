public class Calculator : ICalculator
{
    public double AddNumbers(double a, double b) => a + b;
    public double SubtractNumbers(double a, double b) => a - b;
    public double MultiplyNumbers(double a, double b) => a * b;
    public double DivideNumbers(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;
        }
        return a / b;
    }
}
