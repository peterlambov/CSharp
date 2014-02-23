using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//task 3
public enum BatteryType
{
    LiIon, NiMH, NiCd
}
  public  class Battery
    {
        //fields
        private string model;
        private decimal? hoursIdle;
        private decimal? hoursTalk;
        private BatteryType batteryType;
      //constructors
        public Battery(string mod, decimal? hoursId, decimal? hoursT,BatteryType batteryTy)

        {
            this.Model = mod;
            this.HoursIdle = hoursId;
            this.HoursTalk = hoursT;
            this.BatteryT = batteryTy;
        }

        public Battery(BatteryType batteryTy, string mod)
        {
            this.BatteryT = batteryTy;
            this.Model = mod;
        }
      //properties
        public BatteryType BatteryT
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public string Model
        {
            get{return this.model;}
            set { this.model = value; }
        }

        public decimal? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public decimal? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }

