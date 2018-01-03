namespace MobilePhoneComponents
{
    using System;

    public class ContactInformation
    {
        private string name;
        private string phone;

        public ContactInformation(string name, string phone)
        {
            this.Name = name;
            this.PhoneNumber = phone;
        }

        public string Name
        {
            get
            {
                if (this.name.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                if (this.phone.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.phone;
            }

            private set
            {
                if (!NumberIsValid(value))
                {
                    throw new ArgumentException();
                }

                this.phone = value;
            }
        }

        private bool NumberIsValid(string value)
        {
            foreach (var letter in phone)
            {
                if (!Char.IsDigit(letter) && letter != '+' && letter != '/' && letter != ' ')
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.PhoneNumber);
        }
    }
}
