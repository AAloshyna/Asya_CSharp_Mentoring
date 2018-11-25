using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    public sealed class PublicTeacher: Teacher
    {
        public string School { get; set; }

        public PublicTeacher(string name, string email, string subject, string school) : base(name, email, subject)
        {
            School = school;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Public teacher name: {Name}, Email: {Email}, Subject: {Subject}, School: {School}");
        }
    }
}
