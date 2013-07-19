using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shogun
{
    using Ninject;

    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ShurikenModule());

            var samurai = kernel.Get<Samurai>();

            samurai.Attack("'The dirty masses'");

            Console.Read();
        }
    }
}
