using LogAn.Contracts;

namespace LogAn.Mocks
{
    public class FakeWebService : IWebService
    {
        public void LogError(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
