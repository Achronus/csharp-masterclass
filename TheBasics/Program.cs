// See https://aka.ms/new-console-template for more information

double numOne = GetInput("Enter the first number: ");
double numTwo = GetInput("Enter the second number: ");

Console.WriteLine($"{numOne} + {numTwo} = {AddNumbers(numOne, numTwo)}");

// This line prevents the console from closing immediately
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();


double GetInput(string msg)
{
    while (true) 
    {
        Console.Write(msg);
        string inputValue = Console.ReadLine();

        if (CheckInteger(inputValue))
        {
            return double.Parse(inputValue);
        }

        Console.WriteLine("Invalid number. Please try again.");
    }
}

bool CheckInteger(string value)
{
    if (double.TryParse(value, out _))
    {
        return true;
    }

    return false;
}

double AddNumbers(double a, double b)
{
    return a + b;
}
