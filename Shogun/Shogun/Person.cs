// -----------------------------------------------------------------------
// <copyright file="Person.cs" company="Hewlett-Packard Company">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Shogun
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Person
    {
        private readonly string name;

        private readonly string address;

        private readonly int age;

        public Person(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }
    }
}
