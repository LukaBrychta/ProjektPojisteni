using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída reprezentuje pojištěnou osobu
    /// </summary>
    class Pojisteny
    {
        /// <summary>
        /// Jméno pojištěné osoby
        /// </summary>
        public string Jmeno { get; private set; }
        /// <summary>
        /// Příjmení pojištěné osoby
        /// </summary>
        public string Prijmeni { get; private set; }
        /// <summary>
        /// Věk pojištěné osoby
        /// </summary>
        public int Vek { get; private set; }
        /// <summary>
        /// Telefonní číslo pojištěné osoby
        /// </summary>
        public int TelefonniCislo { get; private set; }
        /// <summary>
        /// Vytvoření pojištěné osoby
        /// </summary>
        /// <param name="jmeno">Jméno pojištěné osoby</param>
        /// <param name="prijmeni">Příjmení pojištěné osoby</param>
        /// <param name="vek">Věk pojištěné osoby</param>
        /// <param name="telefonniCislo">Telefonní číslo pojištěné osoby</param>
        public Pojisteny(string jmeno, string prijmeni, int vek, int telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }
        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}", Jmeno.PadRight(15), Prijmeni.PadRight(15), Vek.ToString().PadRight(10), TelefonniCislo.ToString());
        }
    }
}
