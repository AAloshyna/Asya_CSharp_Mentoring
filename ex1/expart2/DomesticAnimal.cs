using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    public abstract class DomesticAnimal: Animal
    {
       protected DomesticAnimal(string name, string continent)
        {
            Name = name;
            Continent = continent;
        }
    }
}
