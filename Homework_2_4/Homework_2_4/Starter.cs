using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    /// <summary>
    /// Start point in the program.
    /// </summary>
    internal class Starter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Starter"/> class.
        /// </summary>
        public Starter()
        {
        }

        /// <summary>
        /// Startem method.
        /// </summary>
        public void Run()
        {
            Vegetable[] listOfVegetables =
            {
                new Cabage(0.5),
                new Cabage(0.3),
                new Cucumber(0.14),
                new Cucumber(0.4),
                new Tomato(0.2),
                new Tomato(0.1),
                new Tomato(0.24),
                new Beetroot(1),
                new Beetroot(0.15),
            };

            Salad salad = new Salad(6);
            Random rnd = new Random();
            for (int i = 0; i < salad.Size;)
            {
                string message = salad.SortByWeight(listOfVegetables[rnd.Next(0, listOfVegetables.Length)], 0.3);
                Console.WriteLine(message);
                if (message != "Vegetable is too big.")
                {
                    i++;
                }
            }

            Console.WriteLine(salad.MakeSalad());

            Vegetable[] foundVegetables = listOfVegetables.FindVegetableByName("Tomato");
            for (int i = 0; i < foundVegetables.Length; i++)
            {
                Console.WriteLine(foundVegetables[i].GetInfo());
            }
        }
    }
}
