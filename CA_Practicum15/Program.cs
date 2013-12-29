using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Practicum15
{
    class Program
    {
        static void Main(string[] args)
        {
            Batterijproducent p = new Batterijproducent();

            bool stop = false;

            Console.WriteLine("Batterij quality service. Kies een optie: ");
            do
            {
                Console.WriteLine(" 1. Maak een nieuwe verpakking aan.");
                Console.WriteLine(" 2. Geef een overzicht van de huidige verpakking.");
                Console.WriteLine(" 3. Controleer de verpakking.");
                Console.WriteLine(" 4. Verwijder off-spec batterijen.");
                Console.WriteLine(" 5. Stop");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        Console.WriteLine("Aantal batterijen in verpakking: ");
                        int aantalBatterijen = int.Parse(Console.ReadLine());
                        Console.WriteLine("Gewenste voltage: ");
                        double voltage = double.Parse(Console.ReadLine());
                        Console.WriteLine("Verpakking aangemaakt./nDruk op Enter om door te gaan.");
                        break;
                    case "2":
                        PrintBatterijverpakking(p.Voorraad);
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze. Druk op enter om een nieuwe keuze in te geven.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                }

            } while (!stop);
        } 
    }
}
