using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä3_autoluokka
{
    /* Tee autoluokka.
     * Määrittele autoluokalle attribuutit: merkki, malli, bensanMaara. Aseta kaikkein attribuuttien näkyvyydeksi public.
     * Määrittele metodit: jarruta (metodissa konsoliin kirjoitetaan "auto jarruttaa"), Kiihdyta (konsoliin kirjoitetaan "auto kiihtyy" ja bensanMaara arvo pienenee yhdellä),
     * NaytaTiedot (metodi tulostaa konsoliin merkin, mallin ja bensan määrän).
     * Luo auto1-olio ja anna sille arvot merkki, malli ja bensanmaara. Tulosta auton tiedot, kiihdytä autoa ja tulosta uudestaan.
     * Kokeile lisätä Kiihdyta-metodiin ehto, jossa tutkitaan, onko bensa loppu.
     * Lisää Auto-luokkaan Tankkaa-metodi, jolla bensan määrä saadaan asetettua. Eli Tankkaa-metodi saa attribuuttina määrän paljon tankattiin. Huomio tankissa olemassa oleva bensan määrä.
     * Tee konstruktori/muodostin, joka saa parametreikseen merkin, mallin ja bensan määrän. Huomaa, että koska teit konstruktorin oletuskonstruktori katoaa ja täten saat virheilmoituksen auto1-olion 
     * luonnista. Laita vaikka auto1-olion luonti ja muut lauseet kommenteiksi.
     * Luo auto2-olio käyttäen konstruktoria.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Toyota", "Corolla", 1);
            Console.WriteLine(auto1);

            if (auto1.Kiihdyta() == true)
            {
                Console.WriteLine("Auto kiihtyy...");
                Console.WriteLine(auto1);
            }
            else
            {
                Console.WriteLine("Auto kiihtyy...");
                Console.WriteLine("Bensa loppu. Käy tankkaamassa!");
            }
            Console.WriteLine("Haluatko tankata? k/e:");
            char x = Console.ReadKey().KeyChar;
            if (x == 'k')
            {
                int tankattu = 0;
                while (auto1.TankkaaLitra() == true)
                {
                    tankattu++;
                    Console.WriteLine("Tankattu " + tankattu + " litraa.");
                    Console.WriteLine("Haluatko tankata lisää? k/e: ");
                    char c = Console.ReadKey().KeyChar;
                    if (c == 'e')
                    {
                        break;
                    }
                }
                Console.WriteLine("Tankkaus päättynyt. Tankattu yhteensä " + tankattu + " litraa.");
            }
            Console.ReadKey();
        }
    }
}
