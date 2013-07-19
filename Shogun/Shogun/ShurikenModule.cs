using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun
{
    using Ninject;
    using Ninject.Activation;
    using Ninject.Modules;

    class ShurikenModule: NinjectModule
    {
        public override void Load()
        {
            this.Bind<IWeapon>().To<Shuriken>();
            this.Bind(typeof(Func<>)).ToMethod(this.CreateFunc);
        }

        private object CreateFunc(IContext ctx)
        {
            var functionFactoryType = typeof(FunctionFactory<>).MakeGenericType(ctx.GenericArguments);
            var ctor = functionFactoryType.GetConstructors().Single();
            var functionFactory = ctor.Invoke(new object[] { ctx.Kernel });
            return functionFactoryType.GetMethod("Create").Invoke(functionFactory, new object[0]);
        }

        public class FunctionFactory<T>
        {
            private readonly IKernel kernel;

            public FunctionFactory(IKernel kernel)
            {
                this.kernel = kernel;
            }

            public Func<T> Create()
            {
                return () => this.kernel.Get<T>();
            }
        }
    }
}
