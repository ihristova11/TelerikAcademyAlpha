using System;
using System.Collections.Generic;

namespace MobilePhoneComponents
{
    class MobilePhone
    {
        private string model;
        private Manufacturer manufacturer;
        private double price;
        //private Owner owner;
        private Display display;
        private bool displaySet = false;
        private Battery battery;
        private bool batterySet = false;
        private OS oS;
        private bool OSSet = false;
        private List<Call> calls = new List<Call>();


        public MobilePhone(Manufacturer manufacturer, string model) : base()
        {
            this.Manufacturer = manufacturer;

        }

        public MobilePhone(Manufacturer manufaturer, string model, Display display) : this(manufacturer, model)
        {
           
        }

        public MobilePhone(Manufacturer manufacturer, string model, Display display, Battery battery)
        {

        }

        public MobilePhone(Manufacturer manufacturer, string model, Battery battery, Display display, OS os) : this(manufacturer, model)
        {

        }

        public Manufacturer Manufacturer
        {
            get
            {
                if(this.manufacturer.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                if(String.IsNullOrEmpty(this.model))
                {
                    throw new NullReferenceException();
                }

                return this.model;
            }

            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                this.model = value;
            }
        }

        public Display Display
        {
            get
            {
                if(this.display.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.display;
            }

            private set
            {
                this.display = value;
                this.displaySet = true;
            }
        }

        public Battery Battery
        {
            get
            {
                if(this.battery.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.battery;
            }

            private set
            {
                this.battery = value;
                this.batterySet = true;
            }
        }

        public OS OS
        {
            get
            {
                if(this.oS.Equals(null))
                {
                    throw new NullReferenceException();
                }

                return this.oS;
            }

            private set
            {
                this.oS = value;
                this.OSSet = true;
            }
        }

        public enum Manufacturer
        {
            HTC,
            SAMSUNG,
            LG,
            MOTOROLA,
            APPLE,
            NOKIA,
            SONY,
            LENOVO,
            BLACKBERRY,
            ALCATEL,
            CAT,
            ASUS,
            ACER,
            GOOGLE,
            MICROSOFT,
            HUAWEI,
            XIAOMI,
            Other
        }

        public enum OS
        {
            IOS,
            WINDOWS,
            ANDROID,
            SYMBIAN,
            Other
        }

    }
}
