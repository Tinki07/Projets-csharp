using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAnimalerie;

namespace AppAnimalerie
{
    class Program
    {
        static void Main(string[] args)
        {
            LibAnimalerie.Animal nemo = new LibAnimalerie.Animal("Nemo","PoissonRouge");
            LibAnimalerie.Animal felix = new LibAnimalerie.Animal("Félix", "Chat");
            LibAnimalerie.Animal pistache = new LibAnimalerie.Animal("Pistache", "Perruche");
            Menagerie zoo = new Menagerie();

            // La vie de némo se résume ainsi....
            nemo.SePresenter();
            nemo.Parler("Gloup");
            nemo.Manger();
            nemo.Dormir();

            // La vie de félix se résume ainsi....
            felix.SePresenter();
            felix.Parler("Miaou");
            felix.Manger();
            felix.Dormir();

            // La vie de Pistache se résume ainsi....
            pistache.SePresenter();
            pistache.Parler("Gloup");
            pistache.Manger();
            pistache.Dormir();

            //enregistremet des animaux qui arrivent dans la ménagerie
            zoo.Arriver(nemo);
            zoo.Arriver(felix);
            zoo.Arriver(pistache);

            //présentation de la ménageir ainsi constituée
            Console.WriteLine("Le zoo comporte " + zoo.NombreAnimaux + " animaux");
            zoo.Presenter();

            //enregistrement du départ de Félix
            Console.WriteLine("=> Félix s'en va");
            zoo.Partir(felix);

            //re-présentaion de la ménageirie ainsi constituée
            Console.WriteLine("Le zoo comporte " + zoo.NombreAnimaux + " animaux");
            zoo.Presenter();

            //changement du nom de baptême d'un résident
            Console.WriteLine("Le poisson Nemo est rebaptisé Maurice");
            nemo.Nom = "Maurice";

            //re-présentaion de la ménageirie ainsi constituée
            zoo.Presenter();












            Console.ReadKey();
        }
    }
}
