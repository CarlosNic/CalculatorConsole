internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CalculatorConsoleApp.CalculatorClass calculatorClass = new CalculatorConsoleApp.CalculatorClass();
        string str = calculatorClass.Calculate("2*3+4*5-6").ToString();
        Console.WriteLine(str);
    }
}