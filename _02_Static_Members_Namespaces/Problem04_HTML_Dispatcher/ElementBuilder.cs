using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_HTML_Dispatcher
{
    class ElementBuilder
    {
        private string name;
        private string content;
        private Dictionary<string, string> attributes;

        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("element's name can't be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public string Content 
        {
            get { return this.content; } 
        }
        public Dictionary<string, string> Attributes { get; set; }

        public ElementBuilder(string name)
        {
            this.Name = name.ToLower();
            this.content = "";
            this.Attributes = new Dictionary<string, string>();
        }

        public void AddContent(string content)
        {
            this.content = content;
        }

        public void AddAttribute(string name, string value)
        {
            this.Attributes[name.ToLower()] = value;
        }

        public override string ToString()
        {
            string element = "<" + this.Name;
            foreach(KeyValuePair<string, string> pair in this.Attributes)
            {
                element += (" " + pair.Key + "=\"" + pair.Value + "\"");
            }
            element += (">" + this.Content + "</" + this.Name + ">" );
            return element;
        }

        public static string operator *(ElementBuilder first, int count)
        {
            return String.Concat(Enumerable.Repeat(first.ToString(), count));
        }

        public static string operator *(int count, ElementBuilder first)
        {
            return String.Concat(Enumerable.Repeat(first.ToString(), count));
        }
    }
}
