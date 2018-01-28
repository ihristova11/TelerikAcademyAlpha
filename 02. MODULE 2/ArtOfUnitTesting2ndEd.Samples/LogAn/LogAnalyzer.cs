using System;

namespace LogAn
{
    public class LogAnalyzer
    {
        /// <summary>
        /// Injecting stub using constructor injection
        /// </summary>
        private IExtensionManager manager;

        public LogAnalyzer(IExtensionManager mgr)
        {
            manager = mgr;
        }

        public bool IsValidLogFileName(string fileName)
        {
            return manager.IsValid(fileName);
        }

        public bool WasLastFileNameValid { get; set; }


        //public bool IsValidLogFileName(string fileName)
        //{
        //    IExtensionManager mgr = new FileExtensionManager();
        //    return mgr.IsValid(fileName);

        //    //WasLastFileNameValid = false;

        //    //if (string.IsNullOrEmpty(fileName))
        //    //{
        //    //    throw new ArgumentException("filename has to be provided");
        //    //}
        //    //if (!fileName.EndsWith(".SLF",StringComparison.CurrentCultureIgnoreCase))
        //    //{
        //    //    return false;
        //    //}

        //    //WasLastFileNameValid = true;
        //    //return true;
        //}

    }
}
