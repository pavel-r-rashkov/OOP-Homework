using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14_Students_Specialties
{
    class StudentsSpecialties
    {
        public string SpecialtyName { get; set; }
        public int FacNum { get; set; }

        public StudentsSpecialties(string specialtyName, int facNum)
        {
            this.SpecialtyName = specialtyName;
            this.FacNum = facNum;
        }
    }
}
