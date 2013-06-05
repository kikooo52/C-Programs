using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct|
                    AttributeTargets.Class|
                    AttributeTargets.Interface|
                    AttributeTargets.Method|
                    AttributeTargets.Enum)]
    class VersionAttribute : System.Attribute
    {
        private int majorVersion;
        private int minorVersion;

        public int MajorVersion
        {
            get { return this.majorVersion; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Majot Have to be positive");
                }
                this.majorVersion = value;
            }
        }
        public int MinorVersion
        {
            get { return this.minorVersion; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Minor Have to be positive");
                }
                this.minorVersion = value;
            }
        }

        public VersionAttribute(int major, int minor)
        {
            this.MajorVersion = major;
            this.MinorVersion = minor;
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", majorVersion, minorVersion);
        }

    }
}
