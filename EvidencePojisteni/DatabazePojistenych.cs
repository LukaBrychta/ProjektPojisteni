using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída reprezentuje databázi pojištěných osob
    /// </summary>
    class DatabazePojistenych
    {
        public List<Pojisteny> seznamPojistenych = new List<Pojisteny>()
        {
        new Pojisteny("Aleš", "Novotný", 54, 123123123),
        new Pojisteny("Karel", "Nevím", 45, 456456456),
        new Pojisteny("Martin", "Brzobohatý", 41, 789789789),
        new Pojisteny("Tomáš", "Marný", 16, 357357357)
        };

        /// <summary>
        /// Přidání pojištěného do databáze
        /// </summary>
        /// <param name="jmeno">Jméno pojištěné osoby</param>
        /// <param name="prijmeni">Příjmení pojištěné osoby</param>
        /// <param name="vek">Věk pojištěné osoby</param>
        /// <param name="telefonniCislo">Telefonní číslo pojištěné osoby</param>
        public void PridejPojisteneho(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            seznamPojistenych.Add(new Pojisteny(jmeno, prijmeni, vek, telefonniCislo));
        }

        /// <summary>
        /// Vyhledání pojištěného podle jména a příjmení
        /// </summary>
        /// <param name="jmeno">Jméno pojištěné osoby</param>
        /// <param name="prijmeni">Příjmení pojištěné osoby</param>
        /// <returns>List pojištěných osob</returns>
        public List<Pojisteny> VyhledejPojistene(string jmeno, string prijmeni)
        {
            List<Pojisteny> nalezeno = new List<Pojisteny>();

            foreach (Pojisteny p in seznamPojistenych)
            {
                if (jmeno.ToLower().Trim() == p.Jmeno.ToLower().Trim() && prijmeni.ToLower().Trim() == p.Prijmeni.ToLower().Trim())
                {
                    nalezeno.Add(p);
                }
            }
            return nalezeno;
        }


    }
}