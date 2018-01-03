using System.Threading;

namespace Timer
{
    public class Problem7
    {
        public delegate void CountEventHandler();

        public event CountEventHandler counter;
        
        public static void Main()
        {
            Timer obj = new Timer();
            var timer = new Timer.Ticker(obj.TickerPross);

            while (true)
            {
                Thread.Sleep(1000);
                timer(0);
            }
        }
    }
}
