using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun2
{
    using Ninject;

    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ReloadModule());
            var samurai = kernel.Get<Samurai>();

            samurai.Attack("Evil masses");

            Console.ReadLine();
        }
    }
}
