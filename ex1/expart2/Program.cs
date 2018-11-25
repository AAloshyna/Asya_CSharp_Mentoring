using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCat = new Cat("Rigi", "Europe");
            Console.WriteLine($"Cat is domestic: {newCat.IsDomestic}");
            Console.WriteLine($"Name: {newCat.Name}, he is from {newCat.Continent}");
            newCat.Say();
            Console.WriteLine("\n");

            var newTiger = new Tiger("Holi", "Asia");
            Console.WriteLine($"He is wilde:{newTiger.IsWild}");
            Console.WriteLine($"Name: {newTiger.Name}, he is from {newTiger.Continent}");
            newTiger.Say();
            Console.WriteLine("\n");

            var newStudent = new Student("Alice", "alice@gmail.com", "Literature, Biology", "A,C");
            newStudent.DisplayInfo();
            Console.WriteLine("\n");

            var newTeacher = new Teacher("Nicolas Bigle", "nicbigle@gmail.com", "English");
            newTeacher.DisplayInfo();
            Console.WriteLine("\n");

            var newPublicTeacher = new PublicTeacher("Alina Oscarovna", "as@gmail.com", "Mathematics", "liceum");
            newPublicTeacher.DisplayInfo();
            Console.WriteLine("\n");

            var newPrivateTeacher = new PrivateTeacher("Ihor Olegovich", "io@gmail.com", "English", 20);
            newPrivateTeacher.DisplayInfo();
            Console.ReadLine();
            
        }
      
    }
    
}
