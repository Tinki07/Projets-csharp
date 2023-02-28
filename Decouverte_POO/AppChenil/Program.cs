using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAnimalerie;

namespace AppChenil
{
    class Program
    {
        static void Main(string[] args)
        {
            // creation de la menagerie
            Menagerie leChenil = new Menagerie();

            // les chiens prennent vie...
            Chien medor = new Chien("Medor", "Batard", 19);
            Chien saucisse = new Chien("Saucisse", "Teckel", 9);
            Chien pongo = new Chien("Pongo", "Dalmatien", 70);
            Chien perdita = new Chien("Perdita", "Dalmatien", 50);

            // les chiens aboient quand...
            Console.WriteLine("La caravne passe ....");
            medor.Aboyer();
            saucisse.Aboyer();
            Console.WriteLine("Quelle est la taille de Saucisse ?" + saucisse.Taille + " cm\n");
            pongo.Aboyer();
            perdita.Aboyer();
            Animal lol = new Chien("bastos", "oui", 10);
            


            // les chiens vont en pension au chenil
            leChenil.Arriver(medor);
            leChenil.Arriver(saucisse);
            leChenil.Arriver(pongo);
            leChenil.Arriver(perdita);
            leChenil.Arriver(lol);
            // le chenil presente ses pensionnaires
            leChenil.Presenter();
            Console.WriteLine(lol.Espece);
            lol.Manger();
            lol.SePresenter();



            Console.ReadKey();
        }
    }
}
