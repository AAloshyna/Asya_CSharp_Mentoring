using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    public  sealed class PrivateTeacher: Teacher
    {
        public int Students { get; set; }

        public PrivateTeacher(string name, string email, string subject, int students) : base(name, email, subject)
        {
            Students = students;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Privite teacher {Name}, {Email}, Subject: {Subject}, Number of students: {Students}");
        }
    }
}
