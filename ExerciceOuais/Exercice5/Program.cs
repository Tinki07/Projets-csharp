using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            char lettre;

            Console.WriteLine("Saisir une lettre");
            lettre = char.Parse(Console.ReadLine());
        
            switch(lettre)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    Console.WriteLine("La lettre est une voyelle");
                    break;
                default:
                    Console.WriteLine("La lettre est une consonne");
                     break;
            }
         
            
            Console.ReadKey();
        }
    }
}
