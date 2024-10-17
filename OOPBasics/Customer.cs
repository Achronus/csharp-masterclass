namespace OOPBasics
{
    internal class Customer
    {
        private readonly int _id;
        private static int _nextId = 0;

        public static int NumberOfCustomers = 0;

        public int Id => _id;
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public Customer()
        {
            Name = "Unknown";
            Address = "Unknown";
            ContactNumber = "Unknown";

            NumberOfCustomers++;
            _id = _nextId++;
        }

        public Customer(string name) : this()
        {
            Name = name;
        }

        public Customer(string name, string address) : this()
        {
            Name = name;
            Address = address;
        }

        public Customer(string name, string address, string contactNumber): this()
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine();
        }

        public void UpdateDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}