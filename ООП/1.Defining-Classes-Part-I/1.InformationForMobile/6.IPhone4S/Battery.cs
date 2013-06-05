using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IPhone4S
{
    public enum BatteryTypes
    {
        LiIon,
        LiPol,
        NiMh,
        NiCd
    }
  public class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private BatteryTypes _batteryType = BatteryTypes.LiIon;

        public Battery()
        {
        }
        public Battery(string BatteryModel, int HoursIdle, BatteryTypes BateryTypes)
        {
            this._batteryType = BatteryType;
            this.batteryModel = BatteryModel;
            this.hoursIdle = HoursIdle;
        }
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The value is null, enter bigger");
                }
                if (value.Length > 10)
                {
                    throw new ArgumentException("The value must to be less of 10");
                }
                this.batteryModel = value;
            }
        }
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The value not must to be less of null");
                }
                this.hoursIdle = value;
            }
        }
        public BatteryTypes BatteryType
        {
            get { return _batteryType; }
            set { this._batteryType = value; }
        }
    }
}
