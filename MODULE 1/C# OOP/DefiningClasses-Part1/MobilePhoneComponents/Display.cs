using System;

namespace MobilePhoneComponents
{
    public class Display
    {
        private MobileDisplayType displayType;
        private double inches;
        private MobileTouchScreenType touchScreenType;
        private int colors;
        private bool colorsSet = false;
        private bool screenTypeSet = false;

        public Display(MobileDisplayType displayType, double inches) : base()
        {
            this.DisplayType = displayType;
            this.Inches = inches;
        }


        public Display(MobileDisplayType displayType, double inches, int colors) : this(displayType, inches)
        {
            this.Colors = colors;
            this.colorsSet = true;
        }

        public Display(MobileDisplayType displayType, double inches, int colors, MobileTouchScreenType touchScreenType) : this(displayType, inches, colors)
        {
            this.TouchScreenType = touchScreenType;
            this.screenTypeSet = true;
        }

        public MobileDisplayType DisplayType
        {
            get
            {
                return this.displayType;
            }

            private set
            {
                this.displayType = value;
            }
        }

        public double Inches
        {
            get
            {
                return this.inches;
            }

            private set
            {
                if (value <= 0.00)
                {
                    throw new ArgumentException();
                }

                this.inches = value;
            }
        }

        public int Colors
        {
            get
            {
                if(!this.colorsSet)
                {
                    throw new NullReferenceException();
                }

                return this.colors;
            }

            private set
            {
                this.colors = value;
            }
        }

        public MobileTouchScreenType TouchScreenType
        {
            get
            {
                if(!this.screenTypeSet)
                {
                    throw new NullReferenceException();
                }

                return this.touchScreenType;
            }

            private set
            {
                this.touchScreenType = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"Display: {0}, {1} inches {2} {3}",
                this.DisplayType, this.Inches, this.screenTypeSet ? string.Format("Touch screen type: {0}", this.TouchScreenType) : string.Empty,
                this.colorsSet ? string.Format("Colors: {0}", this.Colors) : string.Empty).Trim();
        }

        public enum MobileDisplayType
        {
            CSTN,
            TFT,
            TFD,
            OLED,
            AMOLED,
            LCD
        };

        public enum MobileTouchScreenType
        {
            CAPACITIVE,
            RESISTIVE
        }
    }
}



