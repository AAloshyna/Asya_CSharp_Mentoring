using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ex1.Exercises;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises.Exercise1.ReverseArray();
            //Exercises.Exercise2.CulculateFormula();
            //Exercises.Exercise3.DigitVowel();
            //Exercise4.EvenOrOdd();
            //Exercises.Exercise5.GreatestNumber();
            //Exercises.Exercise6.SubjectsMarks();
            //Exercises.Exercise7.GradeEquivalentDescription();
            //Exercises.Exercise9.MaxElementOfArray();
            //Exercises.Exercise10.ReverseArray();
            //Exercises.Exercise11.FormatDataTime();
            //Exercises.Exercise12.DataTimeAddDays();
            //Exercises.Exercise13.DateCompare();
            //Exercises.Exercise14.CalculateHours();

            //Mark[] marksforStudent1 = new Mark[3];
            //Mark m1 = new Mark(SchoolSubjects.Maths, 2);
            //Mark m2 = new Mark(SchoolSubjects.Biology, 3);
            //Mark m3 = new Mark(SchoolSubjects.Chemistry, 5);

            //marksforStudent1[0] = m1;
            //marksforStudent1[1] = m2;
            //marksforStudent1[2] = m3;

            //Mark[] marksforStudent2 = new Mark[2];
            //Mark ma1 = new Mark(SchoolSubjects.EnglishLiterature, 4);
            //Mark ma2 = new Mark(SchoolSubjects.Physics, 5);

            //marksforStudent2[0] = ma1;
            //marksforStudent2[1] = ma2;


            //Student student1 = new Student("BOb", "Bubbum", "12.12.2002");
            //student1.DisplayStudentInfo();

            //Console.WriteLine($"Average student1 mark: {student1.GetAverageMark(marksforStudent1)}");

            //Student student2 = new Student("Carl", "Carlito", "11.11.2001");
            //student2.DisplayStudentInfo();

            //Console.WriteLine($"Average student2 mark: {student2.GetAverageMark(marksforStudent2)}");
            //Console.ReadLine();

            //var employeeexample = new Employee("Maria", "Boob", 100);
            //employeeexample.DisplayEmployeeInfo();
            //employeeexample.GetEmployeeSalaryPerYear(employeeexample.SalaryPerMonthWithoutTaxes);
            //employeeexample.GetEmployeeSalaryWithTaxes(employeeexample.SalaryPerMonthWithoutTaxes, 20);
            //Console.WriteLine("\n");
            //var employeeexample2 = new Employee("Pipo", "Poo", 200);
            //employeeexample2.DisplayEmployeeInfo();
            //employeeexample2.GetEmployeeSalaryPerYear(employeeexample2.SalaryPerMonthWithoutTaxes);
            //employeeexample2.GetEmployeeSalaryWithTaxes(employeeexample2.SalaryPerMonthWithoutTaxes, 20);
            //Console.ReadLine();

            //    EmployeeForAnalyzer employee1 = new EmployeeForAnalyzer("David", 3, 2000);
            //    EmployeeForAnalyzer employee2 = new EmployeeForAnalyzer("Margo", 4, 3000);

            //    EmployeePerformanceAnalyzer.GetMoreLoyableEmployee(employee1, employee2);
            //    EmployeePerformanceAnalyzer.GetMoreExpensiveEmployee(employee1, employee2);
            //    Console.ReadLine();

            //int side1 = 5;
            //int side2 = 2;
            //int area;

            //Console.WriteLine($"Rectangle area: {RectangleArea.RArea(5, 2)}");
            //Console.WriteLine($"REf type:{RectangleArea.RArea(ref side1, ref side2)}");
            //RectangleArea.RArea(3,6, out area);

            var structRectangle = new StructRectangle(2,5);
            structRectangle.Display();
            Console.ReadLine();

        }
    }
    }

