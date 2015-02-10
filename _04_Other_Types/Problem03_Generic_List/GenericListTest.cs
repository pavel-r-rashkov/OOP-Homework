using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_Generic_List_Version;

namespace Problem03_Generic_List
{
    class GenericListTest
    {
        static void Main(string[] args)
        {
            // look Problem04 - Generic List Version
            var customAttributes = (VersionAttribute[])typeof(GenericList<int>).GetCustomAttributes(typeof(VersionAttribute), true);
            if (customAttributes.Length > 0)
            {
                var versionAttribute = customAttributes[0];
                string version = versionAttribute.GetVersion();
                Console.WriteLine(version);
            }

            GenericList<int> a = new GenericList<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(5);
            a.InsertAt(4, 3);
            a.RemoveAt(3);
            Console.WriteLine(a.Find(7));
            Console.WriteLine(a);
            Console.WriteLine(a.Min());
            Console.WriteLine(a.Max());
        }
    }
}
