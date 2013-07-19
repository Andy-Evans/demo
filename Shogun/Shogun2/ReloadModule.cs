using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun2
{
    using Ninject.Modules;

    class ReloadModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWeapon>().To<Shuriken>();
        }
    }
}
