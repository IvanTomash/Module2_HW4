using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    /// <summary>
    /// Big red fetus.
    /// </summary>
    internal class Tomato : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tomato"/> class.
        /// </summary>
        /// <param name="weight">Represent amount of  vegetable.</param>
        public Tomato(double weight)
            : base("Tomato", 190, weight)
        {
        }
    }
}
