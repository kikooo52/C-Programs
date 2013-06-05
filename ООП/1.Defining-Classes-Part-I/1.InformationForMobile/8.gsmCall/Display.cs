using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.gsmCall
{
  public class Display
    {
        private string size;
        private int numberOfColors;

        public Display()
        {
        }
        public Display(string Size, int NumberOfColors)
        {
            this.size = Size;
            this.numberOfColors = NumberOfColors;
        }
        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
}
