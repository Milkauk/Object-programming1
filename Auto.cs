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
    class Auto
    {
        private string merkki;
        private string malli;
        public int bensanMaara;
        public int tankinKoko = 70;

        public Auto(string merkki, string malli, int bensanMaara)
        {
            this.merkki = merkki;
            this.malli = malli;
            this.bensanMaara = bensanMaara;
        }

        public string Merkki { get => merkki; set => merkki = value; }
        public string Malli { get => malli; set => malli = value; }

        public bool Jarruta()
        {
            return true;
        }
        public bool Kiihdyta()
        {
            bensanMaara--;
            while(bensanMaara <= tankinKoko && bensanMaara>0)
            {
                return true;
            }
            return false;
        }

        public void Tankkaa(int maara)
        {
            if (bensanMaara + maara > tankinKoko)
            {
                bensanMaara = tankinKoko
;            }
            else
            {
                bensanMaara = bensanMaara + maara;
            }
        }
        public bool TankkaaLitra()
        {
            bensanMaara++;
            if (bensanMaara >= tankinKoko)
            {
                return false;
            }
            return true;
        }
        public void NaytaTiedot(string merkki, string malli, int bensanMaara)
        {
            this.merkki = merkki;
            this.malli = malli;
            this.bensanMaara = bensanMaara;
        }
        public override string ToString()
        {
            return "Merkki: " + this.merkki + " " + "Malli: " + this.malli+" "+"Bensan määrä: "+ bensanMaara;
        }
    }
}
