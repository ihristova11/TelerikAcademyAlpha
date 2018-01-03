namespace Attribute
{
    using System;
    
    [Version("2.11")]
    public class Program
    {
        static void Main()
        {
            typeof(Program).GetCustomAttributes(true);
        }
    }
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        public string Name { get; private set; }

        public VersionAttribute(string name)
        {
            System.Console.WriteLine(name);
        }
    }
}
