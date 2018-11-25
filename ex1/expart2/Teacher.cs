using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    public class Teacher: Person
    {
        public string Subject{ get; set; }

        public Teacher(string name, string email, string subject) : base(name, email)
        {
            Subject = subject;
        }



        public override void DisplayInfo()
        {
            Console.WriteLine($"Teacher name: {Name}, Email: {Email}, Subject: {Subject}");
        }
    }
}
