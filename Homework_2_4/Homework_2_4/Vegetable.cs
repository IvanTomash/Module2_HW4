using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    /// <summary>
    /// Base abstraction for all vegetables.
    /// </summary>
    internal abstract class Vegetable
    {
        private readonly string name;
        private readonly double calorie;
        private readonly double weight;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vegetable"/> class.
        /// </summary>
        /// <param name="name">Name of vegetable.</param>
        /// <param name="calorie">Energy value per 1 kg.</param>
        /// <param name="weight">Amout of vegetables in kg.</param>
        protected Vegetable(string name, double calorie, double weight)
        {
            this.name = name;
            this.calorie = calorie;
            this.weight = weight;
        }

        /// <summary>
        /// Gets name.
        /// </summary>
        public string Name
        {
            get { return this.name; }
        }

        /// <summary>
        /// Gets calorie value.
        /// </summary>
        public double Calorie
        {
            get { return this.calorie; }
        }

        /// <summary>
        /// Gets weight value.
        /// </summary>
        public double Weight
        {
            get { return this.weight; }
        }

        /// <summary>
        /// Get calories per certain vegetable.
        /// </summary>
        /// <returns>Calculation result.</returns>
        public double GetCaloriesInThisUnit()
        {
            double res = this.weight * this.calorie;
            return res;
        }

        /// <summary>
        /// Gets all propertiens of vegetable.
        /// </summary>
        /// <returns>All info about vegetable.</returns>
        public string GetInfo()
        {
            string info = string.Empty;
            info = $"Name: {this.Name}\nCalorie: {this.Calorie}\nWeight: {this.Weight}\n";
            return info;
        }
    }
}
