using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    public class Tiger: WildAnimal
    {
        public override bool IsWild
        {
            get { return true; }
        }
        public Tiger(string name, string continent) : base(name, continent) { }

        public override void Say()
        {
            Console.WriteLine($"Tiger says: r-r-r");
        }

    }
}
