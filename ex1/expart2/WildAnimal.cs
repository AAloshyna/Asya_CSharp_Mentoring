using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expart2
{
    public abstract class WildAnimal: Animal
    {
        public WildAnimal(string name, string continent) : base(name, continent) { }

        //public WildAnimal(bool isWild, bool isDomestic) : base(isWild, isDomestic)
        //{
        //    IsWild = isWild;
        //    IsDomestic = isDomestic;
        //}

        private bool _isWild;
        public override bool IsWild
        {
            get { return true; }
        }
    }
}
