using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class UzivatelskeRozhrani
    {
        DatabazePojistenych databazePojistenych = new DatabazePojistenych();
        /// <summary>
        /// Vypíše úvodní obrazovku a menu
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();

            Console.WriteLine("------------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojistěného");
            Console.WriteLine("4 - Konec");

            Console.WriteLine();
        }
        /// <summary>
        /// Načte pojištěného od uživatele a přidá do databáze pojištěných
        /// </summary>
        public void NactiAPridejPojisteneho()
        {
            Console.Write("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine().Trim();
            Console.Write("Zadejte příjmeni: ");
            string prijmeni = Console.ReadLine().Trim();
            Console.Write("Zadejte věk: ");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek) || vek < 0 || vek > 130)
                Console.Write("Neplatný věk, zadejte celé číslo: ");
            Console.Write("Zadejte telefonní číslo: ");
            int telefonniCislo;
            while (!int.TryParse(Console.ReadLine(), out telefonniCislo) || telefonniCislo.ToString().Length != 9)
                Console.Write("Neplatné telefonní číslo, číslo se musí skládat z 9 číslic, zadejte znovu: ");
            databazePojistenych.PridejPojisteneho(jmeno, prijmeni, vek, telefonniCislo);
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...\"");
        }
        /// <summary>
        /// Vypíše všechny pojištěné z databáze pojištěných
        /// </summary>
        public void VypisPojistene()
        {
            Console.WriteLine("Jméno".PadRight(15) + "Přijmení".PadRight(15) + "Věk".PadRight(10) + "Telefonní_číslo\n");
            foreach (Pojisteny p in databazePojistenych.seznamPojistenych)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }
        /// <summary>
        /// Vypíše pojištěné z parametru
        /// </summary>
        /// <param name="nalezeno">seznam pojištěných</param>
        public void VypisPojistene(List<Pojisteny> nalezeno)
        {
            Console.WriteLine("Jméno".PadRight(15) + "Přijmení".PadRight(15) + "Věk".PadRight(10) + "Telefonní_číslo\n");
            foreach (Pojisteny pojisteny in nalezeno)
            {
                Console.WriteLine(pojisteny);
            }
            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }
        /// <summary>
        /// Vyhledá pojštěné podle jména a příjmení a vypíše je
        /// </summary>
        public void VyhledejAVypisPojistene()
        {
            Console.Write("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine().Trim();
            Console.Write("Zadejte příjmeni: ");
            string prijmeni = Console.ReadLine().Trim();

            List<Pojisteny> nalezeno = databazePojistenych.VyhledejPojistene(jmeno, prijmeni);
            
            if (nalezeno.Count > 0)
            {
                Console.WriteLine();
                VypisPojistene(nalezeno);
            }
            else
            {
                Console.WriteLine("Pojištěný nenalezen.");
            }
        }
    }
}
