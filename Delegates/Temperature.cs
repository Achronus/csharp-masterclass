namespace Delegates
{
    public class TemperatureMonitor
    {
        // Equivalent to ...
        //   public delegate void TemperatureChangeHandler(string msg);
        //   public event TemperatureChangeHandler OnTemperatureChange;
        public event Action<string>? OnTemperatureChange = null;

        private int _temperature;

        public int Threshold { get; } = 30;
        public int Temperature 
        { 
            get => _temperature;
            set
            {
                _temperature = value;

                if (_temperature > Threshold)
                {
                    RaiseTempChangeEvent("Temperature is above threshold.");
                }
            }
        }

        protected virtual void RaiseTempChangeEvent(string msg)
        {
            OnTemperatureChange?.Invoke(msg);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChange(string msg)
        {
            Console.WriteLine($"Alert: {msg}");
        }
    }
}
