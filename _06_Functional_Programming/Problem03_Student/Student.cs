using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Student
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
        public string GroupName { get; set; }

        public Student(string firstName, string lastName, int age, int facultyNumber, 
            string phone, string email, int groupNumber, string groupName, params int[] marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
            this.Marks = new List<int>(marks);
        }

        public override string ToString()
        {
            string result = String.Format("first name: {0}\nlast name: {1}\nage: {2}\nf num: {3}\n" +
                "phone {4}\nemail: {5}\ngroup number: {6}\ngroup name: {7}\n", this.FirstName, this.LastName, this.Age,
                this.FacultyNumber, this.Phone, this.Email, this.GroupNumber, this.GroupName);

            foreach(int mark in Marks)
            {
                result += (mark + " ");
            }
            result += "\n====================";
            return result;
        }

        public static void Main()
        {
            List<Student> a = SampleStudents.GetSampleStudents();
        }
    }
}
