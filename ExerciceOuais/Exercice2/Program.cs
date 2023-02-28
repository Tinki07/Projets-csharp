using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialisation des variables
            float temperature;

            Console.WriteLine("La température est de :");
            temperature = float.Parse(Console.ReadLine());

            // on fait un if et else if
            if ( temperature < 0)
            {
                // si la température est inférieur à 0 alors 
                Console.WriteLine("L'eau est à l'état solide");
            }
            else if ( temperature > 100)
            {
                // si la température est supérieur à 100 alors 
                Console.WriteLine("L'eau est à l'état gazeux");
            }
            else
            {
                // si la température est inférieur à 100 alors 
                Console.WriteLine("L'eau est à l'état liquide");
            }

            Console.ReadKey();

        }
    }
}
