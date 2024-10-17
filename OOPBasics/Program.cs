namespace OOPBasics
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

            earl.GetDetails();

            earl.UpdateDetails("Early", "Newstreet 2", "5821234567");

            earl.GetDetails();
            frank.GetDetails();
            Console.WriteLine($"Customer count: {Customer.Count()}");

            Console.ReadKey();
        }
    }
}
