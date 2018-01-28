namespace LogAn.Mocks
{
    public class AlwaysValidFakeExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}
