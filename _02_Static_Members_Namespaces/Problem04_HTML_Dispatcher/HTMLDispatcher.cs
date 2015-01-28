using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_HTML_Dispatcher
{
    static class HTMLDispatcher
    {
        public static ElementBuilder CreateImage(string source, string alt, string title)
        {
            ElementBuilder element = new ElementBuilder("img");
            element.AddAttribute("src", source);
            element.AddAttribute("alt", alt);
            element.AddAttribute("title", title);
            return element;
        }

        public static ElementBuilder CreateURL(string url, string title, string text)
        {
            ElementBuilder element = new ElementBuilder("a");
            element.AddAttribute("href", url);
            element.AddAttribute("title", title);
            element.AddContent(text);
            return element;
        }

        public static ElementBuilder CreateInput(string type, string name, string value)
        {
            ElementBuilder element = new ElementBuilder("input");
            element.AddAttribute("type", type);
            element.AddAttribute("name", name);
            element.AddAttribute("value", value);
            return element;
        }
    }
}
