// See https://aka.ms/new-console-template for more information

Calculator calc = new Calculator();

double numOne = InputToDouble("Enter the first number: ");
double numTwo = InputToDouble("Enter the second number: ");

string op = "";
string[] validOps = ["+", "-", "*", "/"];

double result = 0;

Console.WriteLine("Options -> ['+', '-', '*', '/']");
Console.WriteLine("Please select an arithmetic operation: ");

while (true)
{
    op = Console.ReadLine();

    if (validOps.Any(op.Contains))
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid arithmetic operation. Please try again.");
    }
}

if (numTwo == 0 && op == "/")
{
    Console.WriteLine("Error: cannot divide by zero.");
} else
{
    switch (op)
    {
        case "+":
            result = calc.add(numOne, numTwo);
            break;
        case "*":
            result = calc.mul(numOne, numTwo);
            break;
        case "-":
            result = calc.sub(numOne, numTwo);
            break;
        case "/":
            result = calc.div(numOne, numTwo);
            break;
        default:
            break;
    }

    Console.WriteLine($"Result: {result}");
}

// This line prevents the console from closing immediately
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();

double InputToDouble(string msg)
{
    while (true)
    {
        Console.Write(msg);
        string inputValue = Console.ReadLine();

        if (CheckIfDouble(inputValue))
        {
            return double.Parse(inputValue);
        }

        Console.WriteLine("Invalid number. Please try again.");
    }
}

bool CheckIfDouble(string value)
{
    if (double.TryParse(value, out _))
    {
        return true;
    }

    return false;
}


public class Calculator()
{
    public double add(double a, double b)
    {
        return a + b;
    }

    public double sub(double a, double b)
    {
        return a - b;
    }

    public double mul(double a, double b)
    {
        return a * b;
    }

    public double div(double a, double b)
    {
        return a / b;
    }
}