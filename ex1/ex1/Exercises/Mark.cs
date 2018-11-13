using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    public class Mark
    {
        private SchoolSubjects _subjectName { get; set; }

        public double Value { get; set; }

        public Mark(SchoolSubjects subjectName, double value)
        {

            _subjectName = subjectName;
            Value = value;
        }
    }
}
