﻿namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "Audi");
            Car bmw = new Car("i7", "BMW", true);
            Console.WriteLine();

            Customer earl = new Customer("Earl");
            Customer frank = new Customer("Frank", "Mainstreet 1", "5551234567");

            Console.WriteLine($"{earl.Name} | {earl.Address} | {earl.ContactNumber}");

            earl.UpdateDetails(earl.Name, "Newstreet 2", "5821234567");
            Console.WriteLine($"{earl.Name} | {earl.Address} | {earl.ContactNumber}");
            Console.WriteLine($"Earl ID: {earl.Id} | Frank ID: {frank.Id}");
            Console.ReadKey();
        }
    }
}