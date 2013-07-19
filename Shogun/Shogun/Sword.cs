using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun
{
    public class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped the {0} into half", target);
        }
    }
}
