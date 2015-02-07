using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Student_Class
{
    public class PropertyChangedEventArgs : EventArgs
    {
        private string propertyName;
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public string PropertyName
        {
            get
            {
                return this.propertyName;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Property name can't be null or empty");
                }
                else
                {
                    this.propertyName = value;
                }
            }
        }

        public PropertyChangedEventArgs(string name, string oldValue, string newValue)
        {
            this.PropertyName = name;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        } 
    }
}
