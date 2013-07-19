using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun
{
    class Shuriken : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pierce  {0}'s armour", target);
        }
    }
}
