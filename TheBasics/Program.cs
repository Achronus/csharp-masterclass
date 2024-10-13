// See https://aka.ms/new-console-template for more information

int numOne = GetInput("Enter the first number: ");
int numTwo = GetInput("Enter the second number: ");

Console.WriteLine($"{numOne} + {numTwo} = {AddNumbers(numOne, numTwo)}");

// This line prevents the console from closing immediately
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();


int GetInput(string msg)
{
    while (true) 
    {
        Console.Write(msg);
        string inputValue = Console.ReadLine();

        if (CheckInteger(inputValue))
        {
            return int.Parse(inputValue);
        }

        Console.WriteLine("Invalid number. Please try again.");
    }
}

bool CheckInteger(string value)
{
    int result;
    if (int.TryParse(value, out result))
    {
        return true;
    }

    return false;
}

int AddNumbers(int a, int b)
{
    return a + b;
}
