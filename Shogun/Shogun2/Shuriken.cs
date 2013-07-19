using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun2
{
    class Shuriken : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Pierce the '{0}' armour", target);
        }
    }
}
