using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteniConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("____________________");
            bool pokracovat = true;
            char volba = '0';
            Databaze databaze = new Databaze();

            while (pokracovat)
            {
                Console.WriteLine("\n\nVyberte akci");
                Console.WriteLine("1 - Přidat nového pojištěnce");
                Console.WriteLine("2 - Vypsat všechny pojištěnce");
                Console.WriteLine("3 - Vyhledat pojištěnce");
                Console.WriteLine("4 - Konec");
                Console.Write("\nVaše volba: ");

                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (volba)
                {
                    case '1':
                        databaze.PridejPojistence();
                        break;

                    case '2':
                        databaze.VypisPojistencu();
                        break;

                    case '3':
                        databaze.HledejPojistence();
                        break;

                    case '4':
                            Console.WriteLine("Konec");
                            pokracovat = false;
                            break;
                        
                    default:
                        Console.WriteLine("Chybná volba");
                        break;
                }

            }
            Console.Write("Děkuji za použití programu Evidence pojištěnců.");

            Console.ReadKey();
        }
    }
}
