namespace Dealership
{
    using Dealership.Engine;

    public class Startup
    {
        public static void Main()
        {
            DealershipEngine.Instance.Start();
        }
    }
}
