using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    public abstract class Animal
    {
        private string _name;
        private string _continent;

        public string Name { get; set;}
        public string Continent { get; set;}

        public virtual bool IsWild { get; set;}
        public virtual  bool IsDomestic { get; set; }

        public Animal(){}

        public Animal(string name, string continent)
        {
            Name = name;
            Continent = continent;
            
        }

        public Animal(bool isWild, bool isDomestic)
        {
            IsWild = isWild;
            IsDomestic = isDomestic;
        }

        public Animal(string name, string continent, bool isWild, bool isDomestic)
        {
            Name = name;
            Continent = continent;
            IsWild = isWild;
            IsDomestic = isDomestic;

        }

        public Animal(string name, string continent, bool isDomestic)
        {
            Name = name;
            Continent = continent;
            IsDomestic = isDomestic;

        }
        public abstract void Say();
        
    }
}
