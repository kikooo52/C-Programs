using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InformationForMobile
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
            set { this.batteryModel = value; }
        }
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
        public BatteryType BatteryType
        {
            get { return _batteryType; }
            set { this._batteryType = value; }
        }
    }
}
