using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun
{
    using Ninject.Modules;

    class SwordModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWeapon>().To<Sword>();
        }
    }
}
