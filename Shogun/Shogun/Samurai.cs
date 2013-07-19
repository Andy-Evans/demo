using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun
{
    class Samurai
    {
        private readonly IWeapon weapon;

        public readonly Func<string, string, int, Person> createPerson;

        public Samurai(IWeapon weapon, Func<string, string, int, Person> createPerson )
        {
            this.weapon = weapon;
            this.createPerson = createPerson;
        }

        public void Attack(string target)
        {
            Person person = this.createPerson("Hk", "Booths Park", 30);
            this.weapon.Hit(target);
        }
    }
}
