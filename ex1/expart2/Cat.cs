using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    public class Cat: DomesticAnimal
    {
        private bool _isDomestic;
        public override bool IsDomestic
        {
            get { return true; }

        }
        public Cat(string name, string continent) : base(name, continent) {}

        public override void Say()
        {
            Console.WriteLine($"Cat says: mur-mur");
        }
    }
}
