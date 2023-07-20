using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    /// <summary>
    /// Big red root.
    /// </summary>
    internal class Beetroot : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beetroot"/> class.
        /// </summary>
        /// <param name="weight">Represent amount of  vegetable.</param>
        public Beetroot(double weight)
            : base("Beetroot", 370, weight)
        {
        }
    }
}
