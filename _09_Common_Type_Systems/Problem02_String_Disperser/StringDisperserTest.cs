namespace Problem02_String_Disperser
{
    using System;

    class StringDisperserTest
    {
        static void Main(string[] args)
        {
            StringDisperser a = new StringDisperser("a", "b", "c");
            StringDisperser b = (StringDisperser)a.Clone();

            Console.WriteLine(a);
            Console.WriteLine(b);

            foreach(var ch in a)
            {
                Console.Write(ch + " ");
            }       
        }
    }
}
