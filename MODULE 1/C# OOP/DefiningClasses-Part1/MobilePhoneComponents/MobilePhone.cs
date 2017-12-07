namespace MobilePhoneComponents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MobilePhone
    {
        private static readonly MobilePhone meizuMX4Pro = new MobilePhone(MobileManufacturer.MEIZU, "MX4PRO",
            new Display(Display.MobileDisplayType.LCD, 5.5), new Battery(Battery.MobileBatteryType.LiIon, 5000));

        private string model;
        private MobileManufacturer manufacturer;
        private double price;
        //private Owner owner;
        private Display display;
        private bool displaySet = false;
        private Battery battery;
        private bool batterySet = false;
        private MobileOS oS;
        private bool OSSet = false;
        private List<Call> calls = new List<Call>();


        public MobilePhone(MobileManufacturer manufacturer, string model) : base()
        {
            this.Manufacturer = manufacturer;
            this.Model = model;

        }

        public MobilePhone(MobileManufacturer manufaturer, string model, Display display) : this(manufaturer, model)
        {
            this.Display = display;
            this.displaySet = true;
        }

        public MobilePhone(MobileManufacturer manufacturer, string model, Display display, Battery battery) : this(manufacturer, model, display)
        {
            this.Battery = battery;
            this.batterySet = true;
        }

        public MobilePhone(MobileManufacturer manufacturer, string model, Battery battery, Display display, MobileOS os) : this(manufacturer, model, display, battery)
        {
            this.OS = os;
            this.OSSet = true;
        }

        public MobileManufacturer Manufacturer
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

        public MobileOS OS
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

        public static MobilePhone MeizuMx4Pro
        {
            get
            {
                return meizuMX4Pro;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.calls);
            }
        }

        public void AddCalls(Call call)
        {
            this.calls.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.calls.Remove(call);
        }

        public void DeleteCallHistory()
        {
            this.calls.Clear();
        }

        public decimal GetTotalCallPrice(decimal pricePerMinute)
        {
            decimal allCallsInSecs = (decimal)(this.calls.Select(x => x.Duration).Sum());
            return pricePerMinute * allCallsInSecs / 60.0m;
        }

        public override string ToString()
        {
            return string.Format(@"{0} {1} {2} {3} {4}", this.Manufacturer, this.Model, this.OSSet ? string.Format("{1}\t(OS: {0})", this.OS, Environment.NewLine) : String.Empty,
                 !this.batterySet ? String.Empty : String.Format("{0}{0}{1}", Environment.NewLine, this.Battery.ToString()),
                 !this.displaySet ? String.Empty : String.Format("{0}{0}{1}", Environment.NewLine, this.Display.ToString()))
                 .Trim();
        }

        public enum MobileManufacturer
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
            MEIZU,
            Other
        }

        public enum MobileOS
        {
            IOS,
            WINDOWS,
            ANDROID,
            SYMBIAN,
            Other
        }

    }
}
