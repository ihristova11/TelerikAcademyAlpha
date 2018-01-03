namespace Events
{
    using System;

    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
