using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_HTML_Dispatcher
{
    class HTMLDispatcherTest
    {
        static void Main(string[] args)
        {
            ElementBuilder element = new ElementBuilder("Div");
            element.AddContent("content");
            element.AddAttribute("Id", "myId");
            element.AddAttribute("class", "myClass");
            Console.WriteLine(element * 3);
            Console.WriteLine("==========");

            ElementBuilder image = HTMLDispatcher.CreateImage("http://google.bg", "imagealt", "myTitle");
            Console.WriteLine(image);
            ElementBuilder url = HTMLDispatcher.CreateURL("http://google.bg", "urltitle", "text");
            Console.WriteLine(url);
            ElementBuilder input = HTMLDispatcher.CreateInput("text", "myName", "myValue");
            Console.WriteLine(input);
        }
    }
}
