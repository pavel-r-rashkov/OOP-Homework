using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_PC_Catalog
{
    class PCCatalogTest
    {
        static void Main(string[] args)
        {
            Computer firstComp = new Computer("Trashcan - 2000", new Component("graphics card", 400.9M), new Component("RAM", 210),
                new Component("HDD", 320), new Component("processor", 120.5M, "Best processor in the world!"));

            Computer secondComp = new Computer("Trashcan - 3000", new Component("graphics card", 700.9M), new Component("RAM", 310),
                new Component("HDD", 320), new Component("processor", 220.5M, "Best processor in the universe!"));

            Computer thirdComp = new Computer("Trashcan - 4000", new Component("graphics card", 200.9M), new Component("RAM", 110),
                new Component("HDD", 220), new Component("processor", 120.5M));

            List<Computer> computers = new List<Computer>();
            computers.Add(firstComp);
            computers.Add(secondComp);
            computers.Add(thirdComp);

            IEnumerable<Computer> orderedComputers = computers.OrderBy( computer => computer.Price);

            foreach (var computer in orderedComputers) 
            {
                Console.WriteLine(computer.ToString());
            }
        }
    }
}
