using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationWhitConstructor
{
    class Display
    {
        private string size;
        private string numberOfColors;

        public Display()
        {
        }
        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public string NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

    }
}
