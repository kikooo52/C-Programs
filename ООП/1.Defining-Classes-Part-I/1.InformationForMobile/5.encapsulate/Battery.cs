using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.encapsulate
{
    enum BatteryType
    {
        LiIon,
        LiPol,
        NiMh,
        NiCd
    }
    class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private BatteryType _batteryType = BatteryType.LiIon;

        public Battery()
        {
        }
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set {
                if (value == null)
                {
                    throw new ArgumentNullException("The value is null, enter bigger");
                }
                if (value.Length > 10)
                {
                    throw new ArgumentException("The value must to be less of 10");
                }
                this.batteryModel = value; }
        }
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set {
                if (value < 0)
                {
                    throw new ArgumentNullException("The value not must to be less of null");
                }                
                this.hoursIdle = value; }
        }
        public BatteryType BatteryType
        {
            get { return _batteryType; }
            set { this._batteryType = value; }
        }
    }
}
