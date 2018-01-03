using System;

namespace Timer
{
    public class Timer
    {
        public delegate void Ticker(int start);

        public int Nums { get; set; }

        public void TickerPross(int start)
        {
            Console.WriteLine(this.Nums);
            this.Nums++;
        }
    }
}
