using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun2
{
    class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped the '{0}' into 2 halves", target);
        }
    }
}
