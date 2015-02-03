using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    class Teacher : Person
    {
        public HashSet<Discipline> Disciplines { get; private set; }

        public Teacher(string name)
            :base(name)
        {
            this.Disciplines = new HashSet<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }
    }
}
