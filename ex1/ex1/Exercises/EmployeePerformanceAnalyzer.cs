using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    static class EmployeePerformanceAnalyzer
    {
       public static void  GetMoreLoyableEmployee(EmployeeForAnalyzer employee1, EmployeeForAnalyzer employee2)
        {
            if (employee1.DurationOfWork > employee2.DurationOfWork)
            {
                Console.WriteLine(employee1.Name +" worked longer ");
            }
            else
            {
                Console.WriteLine(employee2.Name + " worked longer ");
            }
        }

       public static void GetMoreExpensiveEmployee(EmployeeForAnalyzer employee1, EmployeeForAnalyzer employee2)
        {
            if (employee1.Salary > employee2.Salary)
            {
                Console.WriteLine(employee1.Name + " salary bigger ");
            }
            else
            {
                Console.WriteLine(employee2.Name + " salary bigger ");
            }
        }

    }
}
