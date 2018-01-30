using LogAn.Contracts;

namespace LogAn.Mocks
{
    public class FakeWebService : IWebService
    {
        public string lastError;

        public void LogError(string message)
        {
            this.lastError = message;
        }
    }
}
