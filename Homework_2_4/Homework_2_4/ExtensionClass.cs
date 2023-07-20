using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    /// <summary>
    /// Used for extensions methods.
    /// </summary>
    internal static class ExtensionClass
    {
        /// <summary>
        /// Find vegetable from an array.
        /// </summary>
        /// <param name="veg">Extended type.</param>
        /// <param name="name">Parameter for search.</param>
        /// <returns>An array of appropriate objects.</returns>
        public static Vegetable[] FindVegetableByName(this Vegetable[] veg, string name)
        {
            Vegetable[] extraArr = new Vegetable[veg.Length];
            int counter = 0;
            foreach (var vegetable in veg)
            {
                if (vegetable.Name == name)
                {
                    extraArr[counter++] = vegetable;
                }
            }

            Vegetable[] result = new Vegetable[counter];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = extraArr[i];
            }

            return result;
        }
    }
}
