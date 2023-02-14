using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniConsole
{
    internal class Databaze
    {
        List<Pojistenec> Pojistenci = new List<Pojistenec>();
        /// <summary>
        /// Přidá nového pojištěnce
        /// </summary>
        public void PridejPojistence()
        {
            Console.WriteLine("Zadání nového pojištěnce");
            Console.Write("Jméno : ");
            string jmeno = Console.ReadLine();
            Console.Write("Příjmeni : ");
            string prijmeni = Console.ReadLine();
            Console.Write("Telefonní číslo : ");
            string telefonniCislo = Console.ReadLine();
            
            int vek;
            int pocitadloPokusu = 1 ;
            do {
                if (pocitadloPokusu == 1) Console.Write("Věk : ");
                else Console.Write("Chybné zadání. Zadaná hodnota musí být v rozmezí 0-120 let. Zkuste to prosím znovu....\nVěk : ");
                pocitadloPokusu++;

            } while ((!int.TryParse(Console.ReadLine(), out vek)) || (vek <0) || (vek > 120));
            
            Pojistenci.Add( new Pojistenec( jmeno, prijmeni, telefonniCislo, vek));
            Console.Write("Data byla uložena. Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }
        /// <summary>
        /// Vypíše všechny evidované pojištěnce.
        /// </summary>
        public void VypisPojistencu()
        {
            Console.WriteLine("Výpis pojištěnců");

            foreach (Pojistenec pojistenec in Pojistenci)
            {
                Console.WriteLine(pojistenec);
            }
        }
        /// <summary>
        /// Vyzved z zadání jména a příjmení a následně vyhledá všechny shody.
        /// </summary>
        public void HledejPojistence()
        {
            bool nalezenaShoda = false; // pomocná proměnná pro případ nalezení shody
            Console.WriteLine("Hledám pojištěnce:");
            Console.Write("Zadej jméno: ");
            string hledaneJmeno = Console.ReadLine();
            Console.Write("Zadej příjmení: "); 
            string hledanePrijmeni = Console.ReadLine();
            //Console.Write($"Jdu hledat jmeno: {hledaneJmeno} a prijmeni {hledanePrijmeni}");
            
            foreach (Pojistenec pojistenec in Pojistenci)
            {
                 if ((pojistenec.vratJmeno().ToUpper().Trim() == hledaneJmeno.ToUpper().Trim())
                    && (pojistenec.vratPrijmeni().ToUpper().Trim() == hledanePrijmeni.ToUpper().Trim()))
                    {
                    // pokud najdu shodu, barvím na zeleno.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nNašel jsem shodu ve jménu {pojistenec.vratJmeno()} a příjmení {pojistenec.vratPrijmeni()}");
                        nalezenaShoda = true; // při první shodě nastavím na true
                    }
                
            }
            // Pokud nebyla nalezena shoda, vypiš na obrazovku a ještě zvýrazni výsledek hledání.
            if (!nalezenaShoda)
             {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nBohužel jsem žádnou shodu nenašel...");
            }
            Console.ResetColor(); // nastavení Default hodnoty barvy console

        }
    }
}
