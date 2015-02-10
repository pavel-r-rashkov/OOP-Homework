using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Generic_List_Version
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                           System.AttributeTargets.Struct |
                           System.AttributeTargets.Interface |
                           System.AttributeTargets.Enum |
                           System.AttributeTargets.Method )
    ]
    public class VersionAttribute : Attribute
    {
        private double version;
        
        public VersionAttribute(double version)
        {
            this.Version = version;
        }
        
        private double Version
        {
            get
            {
                return this.version;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Version number can't be negative or 0!");
                }
                this.version = value;
            }
        }
        
        public string GetVersion()
        {
            return String.Format("Version: {0}", this.Version.ToString(CultureInfo.InvariantCulture));
        }
    }
}
