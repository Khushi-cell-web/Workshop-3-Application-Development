using System.Data;

namespace Task_1;

public class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine("sum: "+(a+b));
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine("difference: "+(a-b));
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine("mult: "+(a*b));
    }

    public void Divide(int a, int b)
    {
        if (b!=0)
            Console.WriteLine($"Division: {(double)a / b}");
        else
            Console.WriteLine("Cannot divide by zero!");
    }

    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? "even" : "odd";
        Console.WriteLine(result);
    }
}