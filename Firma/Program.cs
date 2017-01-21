using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        class Työntekijä
        {
            string nimi;
            string ammatti;
            decimal palkka;

            public Työntekijä()
            {
              
            }
            public Työntekijä(string nimi, string ammatti, decimal palkka)
            {
                this.nimi = nimi;
                this.ammatti = ammatti;
                this.palkka = palkka;

            }
            public void TyontekijanTiedot()
            {
                Console.WriteLine("Palkoillinen:");
                Console.WriteLine("Nimi: " + nimi +", ammatti: " +ammatti +  ", palkka: " + palkka + ".");
            }
        }

        class Johtaja
        {
            string nimi;
            string ammatti;
            decimal palkka;
            string auto;
            decimal bonus;


            public Johtaja()
            {
              
            }

            public Johtaja(string nimi, string ammatti, decimal palkka, string auto, decimal bonus)
            {
                this.nimi = nimi;
                this.ammatti = ammatti;
                this.palkka = palkka;
                this.auto = auto;
                this.bonus = bonus;
                
            }

            public void JohtajaTiedot()
            {
                Console.WriteLine("Johtaja:");
                Console.WriteLine("Nimi: " + nimi + ", ammatti: " + ammatti + ", palkka: " + palkka + ", kulkuneuvo: " + auto + ", Bonus: " + bonus + "€.");
            }
        }

        
        static void Main(string[] args)
        {
            Työntekijä Työntekijä1 = new Työntekijä("Nakki Valtonen", "Asentaja", 2450.75m);
            Työntekijä Työntekijä2 = new Työntekijä("Petteri Isokoura", "Näppäimistö asiantuntija", 5600);
            Työntekijä Työntekijä3 = new Työntekijä("Alma Kassi", "Johtaja", 18900);
            Työntekijä1.TyontekijanTiedot();
            Työntekijä2.TyontekijanTiedot();
            Työntekijä3.TyontekijanTiedot();
            Console.WriteLine();

            Johtaja Johtaja1 = new Johtaja("Jack","Big Boss", 250000, "UTH-66 BLACKFOOT", 130000);
            Johtaja Johtaja2 = new Johtaja("Anssi Nakkinen", "Head of wall staring department", 16701, "Jaguar, E-Type", 1090066);
            Johtaja1.JohtajaTiedot();
            Johtaja2.JohtajaTiedot();
            Console.WriteLine("\n");

            Työntekijä Työntekijä4 = new Työntekijä("Jooseppi Puolanka", "Kullankaivaja", 4500);
            Työntekijä1.TyontekijanTiedot();
            Työntekijä2.TyontekijanTiedot();
            Työntekijä4.TyontekijanTiedot();
            Console.WriteLine();

            Johtaja Johtaja3 = new Johtaja("Alma Kassi", "Johtaja", 18900, "BMW x5", 1990122.5m);
            Johtaja1.JohtajaTiedot();
            Johtaja2.JohtajaTiedot();
            Johtaja3.JohtajaTiedot();
            Console.WriteLine("\n");


        }
    }
}
