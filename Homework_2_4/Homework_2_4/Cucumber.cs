using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    /// <summary>
    /// Long green stick.
    /// </summary>
    internal class Cucumber : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cucumber"/> class.
        /// </summary>
        /// <param name="weight">Represent amount of  vegetable.</param>
        public Cucumber(double weight)
            : base("Cucumber", 150, weight)
        {
        }
    }
}
