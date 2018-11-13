using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class EmployeeForAnalyzer
    {
        public string Name { get; set; }
        public int DurationOfWork { get; set;}
        public double Salary { get; set; }

        public EmployeeForAnalyzer()
        { }

        public EmployeeForAnalyzer(string name, int durationOfWork, double salary)
        {
            Name = name;
            DurationOfWork = durationOfWork;
            Salary = salary;
            
        }
    }
}
