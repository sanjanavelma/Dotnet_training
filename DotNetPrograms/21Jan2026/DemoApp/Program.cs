using MathLibrary;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(5, 10));
        Console.WriteLine(calc.Sub(10, 5));
    }
}