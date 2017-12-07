namespace MobilePhoneComponents
{
    class Display
    {
        private DisplayType displayType;
        private double size;

        public Display()
        {

        }


        public enum DisplayType
        {
            CSTN,
            TFT,
            TFD,
            OLED,
            AMOLED,
            LCD
        };

        public enum TouchScreenType
        {
            CAPACITIVE,
            RESISTIVE
        }
    }
}



