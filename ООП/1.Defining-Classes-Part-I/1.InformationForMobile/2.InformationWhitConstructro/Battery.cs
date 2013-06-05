using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationWhitConstructor
{
    class Battery
    {
        private string batteryModel;
        private int hoursIdle;

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
    }
}
