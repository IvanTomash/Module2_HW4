using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    /// <summary>
    /// Big puff green ball.
    /// </summary>
    internal class Cabage : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cabage"/> class.
        /// </summary>
        /// <param name="weight">Represent amount of  vegetable.</param>
        public Cabage(double weight)
            : base("Cabage", 290, weight)
        {
        }
    }
}
