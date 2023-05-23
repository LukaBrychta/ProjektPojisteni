using System.ComponentModel.Design;

namespace EvidencePojisteni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UzivatelskeRozhrani uzivatelskeRozhrani = new UzivatelskeRozhrani();

            bool konec = false;

            // Hlavní cyklus
            while (!konec)
            {
                // Vypsání hlavního menu
                uzivatelskeRozhrani.VypisUvodniObrazovku();

                // Volba uživatele
                int volba;           
                    while (!int.TryParse(Console.ReadLine(), out volba) || volba > 4 || volba < 1)
                        Console.WriteLine("Neplatná volba, vyberte si akci ze seznamu\n");
                    Console.WriteLine();

                switch (volba)
                {
                    case 1: // Přidání nového pojištěného
                        uzivatelskeRozhrani.NactiAPridejPojisteneho();                       
                    break;

                    case 2: // Výpis pojištěných osob
                        uzivatelskeRozhrani.VypisPojistene();
                    break;
                    case 3: // Vyhledání pojištěného
                        uzivatelskeRozhrani.VyhledejAVypisPojistene();
                    break;
                    case 4: // Ukočení aplikace
                        konec = true;
                        Console.WriteLine("Ukončete libovolnou klávesou");
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}