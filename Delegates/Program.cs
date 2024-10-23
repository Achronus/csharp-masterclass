
namespace Delegates
{
    internal class Program
    {
        public delegate void Notify(string msg);

        static void Main(string[] args)
        {
            // Delegates: provide a way to pass methods as parameters
            Notify displayMsg = ShowMessage;

            displayMsg("Hello!");

            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();

            monitor.OnTemperatureChange += alert.OnTemperatureChange;

            // Code below is same as above subscription
            //monitor.OnTemperatureChange += msg =>
            //{
            //    Console.WriteLine($"Alert: {msg}");
            //};

            monitor.Temperature = 20;  // No event
            monitor.Temperature = 35;  // Runs event
        }

        static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
