namespace Delegates
{
    public class StockPrice(decimal threshold)
    {
        public event Action<string>? OnStockPriceChange = null;

        private decimal _price;

        public decimal Threshold { get; } = threshold;
        public decimal Price 
        { 
            get => _price; 
            set
            {
                _price = value;

                if (_price > Threshold)
                {
                    RaiseStockPriceChangeEvent("Stock price is below threshold!");
                }
            }
        }

        public virtual void RaiseStockPriceChangeEvent(string msg)
        {
            OnStockPriceChange?.Invoke(msg);
        }
    }

    public class StockAlert
    {
        public void OnStockPriceChange(string msg)
        {
            Console.WriteLine($"Stock Alert: {msg}");
        }
    }
}
