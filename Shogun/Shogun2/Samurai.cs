using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun2
{
    class Samurai
    {
        private readonly IWeapon weapon;
        
        public Samurai(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
