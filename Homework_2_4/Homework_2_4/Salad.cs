using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    /// <summary>
    /// Represents a mix of vegetables.
    /// </summary>
    internal class Salad
    {
        private Vegetable[] vegetables;
        private int pointer = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Salad"/> class.
        /// </summary>
        /// <param name="size">Number of vegetables in the salad.</param>
        public Salad(int size)
        {
            this.vegetables = new Vegetable[size];
        }

        /// <summary>
        /// Gets number of ingerients.
        /// </summary>
        public int Size
        {
            get
            {
                return this.vegetables.Length;
            }
        }

        /// <summary>
        /// Expand your salad with new ingredient.
        /// </summary>
        /// <param name="ingredient">Your vegetable.</param>
        /// <returns>Message about successeful operation.</returns>
        public string AddIngredient(Vegetable ingredient)
        {
            if (this.pointer < this.vegetables.Length)
            {
                this.vegetables[this.pointer] = ingredient;
                this.pointer++;
                return $"You successfully added new {ingredient.Name}.";
            }

            return "Salad can't be expanded anymore.";
        }

        /// <summary>
        /// Return info about your salad.
        /// </summary>
        /// <returns>Message.</returns>
        public string MakeSalad()
        {
            double totalCalories = 0;
            string res = string.Empty;
            res += $"Your salad contains {this.vegetables.Length} vegetablse.\n";
            for (int i = 0; i < this.vegetables.Length; i++)
            {
                res += $"{this.vegetables[i].GetInfo()}\n";
                totalCalories += this.vegetables[i].GetCaloriesInThisUnit();
            }

            res += $"Calories in the salad: {totalCalories}\n";
            return res;
        }

        /// <summary>
        /// Descending.
        /// </summary>
        /// <param name="igredient">New vegetable.</param>
        /// <param name="weight">Max weight.</param>
        /// <returns>Message.</returns>
        public string SortByWeight(Vegetable igredient, double weight)
        {
            if (igredient.Weight <= weight)
            {
                return this.AddIngredient(igredient);
            }

            return "Vegetable is too big.";
        }
    }
}
