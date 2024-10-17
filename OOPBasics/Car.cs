namespace OOPBasics
{
    internal class Car
    {
        public string Model { get; }
        public string Brand { get; } 
        public bool IsLuxury { get; }

        public string DisplayBrand => IsLuxury ? $"{Brand} - Luxury Edition" : Brand;

        public Car(string model, string brand, bool isLuxury = false)
        {
            ErrorIfNullOrEmpty(model);
            ErrorIfNullOrEmpty(brand);

            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;

            Console.WriteLine($"An '{DisplayBrand}' of the model '{Model}' has been created.");
        }

        private static void ErrorIfNullOrEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
    }
}