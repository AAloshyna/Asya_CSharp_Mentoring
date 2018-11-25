using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    class Student: Person
    {
        public string Classes { get; set;}
        public string Grades { get; set; }

        public Student(string name, string email, string classes, string grades) : base(name, email)
        {
            Classes = classes;
            Grades = grades;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student name: {Name}, Email: {Email}, Classes: {Classes}, Grades: {Grades}");
        }
    }
}
