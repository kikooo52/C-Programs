using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InfoForException
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T min;
        private T max;
        private T wrongNumber;

        public InvalidRangeException(T Max, T Min, T WrongNumber)
        {
            this.wrongNumber = WrongNumber;
            this.max = Max;
            this.min = Min;
        }

        public override string Message
        {
            get
            {
                return string.Format("The value: {0} is out of range betwen:{1}, and:{2}",wrongNumber, min, max);
            }
        }
    }
}
