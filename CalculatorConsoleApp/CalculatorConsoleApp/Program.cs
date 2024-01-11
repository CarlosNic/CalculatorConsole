internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CalculatorConsoleApp.CalculatorClass calculatorClass = new CalculatorConsoleApp.CalculatorClass();
        string str = calculatorClass.Calculate("teste");
        Console.WriteLine(str);
    }
}