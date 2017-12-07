namespace MobilePhoneComponents
{
    using System;
    public class Battery
    {
        private MobileBatteryType batteryType;
        private int mAh;
        private int hoursIdle;
        private int hoursTalk;
        private bool talkSet = false;
        private bool idleSet = false;

        public Battery(MobileBatteryType batteryType, int mAh) : base()
        {
            this.BatteryType = batteryType;
            this.MAh = mAh;
        }

        public Battery(MobileBatteryType batteryType, int mAh, int hoursIdle, int hoursTalk) : this(batteryType, mAh)
        {
            this.HoursTalk = hoursTalk;
            this.talkSet = true;
            this.HoursIdle = hoursIdle;
            this.idleSet = true;
        }

        public MobileBatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }

            private set
            {
                this.batteryType = value;
            }

        }

        public int MAh
        {
            get
            {
                return this.mAh;
            }

            set
            {
                this.mAh = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                if (!this.idleSet)
                {
                    throw new NullReferenceException();
                }

                return this.hoursIdle;
            }

            set
            {
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                if (!this.talkSet)
                {
                    throw new NullReferenceException();
                }

                return this.hoursTalk;
            }

            private set
            {
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"Battery: {0},{1} mAh {2} {3}", this.BatteryType, this.MAh,
                this.talkSet ? string.Format("Talk time: {0}h", this.HoursTalk) : string.Empty,
                this.idleSet ? string.Format("Idle Time: {0}h", this.HoursIdle) : string.Empty).Trim();
        }

        public enum MobileBatteryType
        {
            LiIon,
            LiPol,
            NiMH,
            NiCd
        };
    }
}
