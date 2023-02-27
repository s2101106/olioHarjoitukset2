using System;

namespace nuoliaKaupan
{
    internal class program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Luokka nuoli= new Luokka();
                Console.Write("Minkälainen kärki (puu, teräs vai timantti):");
                string kärki=Console.ReadLine();
                if (kärki == "puu") 
                {
                    nuoli.SetKarkiHinta(3);
                }
                if (kärki == "teräs")
                {
                    nuoli.SetKarkiHinta(5);
                }
                if (kärki == "timantti")
                {
                    nuoli.SetKarkiHinta(50);
                }

                Console.Write("Minkälainen perä (lehti, kanansulka vai kotkansulka):");
                string perä = Console.ReadLine();
                if (perä == "lehti")
                {
                    nuoli.SetPeraHinta(0);   
                }
                if (perä == "kanansulka")
                {
                    nuoli.SetPeraHinta(1);
                }
                if (perä == "kotkansulka")
                {
                    nuoli.SetPeraHinta(5);
                }

                Console.Write("Nuolen pituus (60-100cm):");
                string pituus = Console.ReadLine();
                nuoli.SetVarsiPituus(Convert.ToInt32(pituus)); 



                Console.WriteLine(nuoli.PalautaHinta(nuoli.GetVarsiPituus(), nuoli.GetPeraHinta(), nuoli.GetKarkiHinta()));
            
            }
        }
        class Luokka
        {
            private int _varsiPituus;
            private int _karkiHinta;
            private int _peraHinta;
            private Karki karkiNuolessa;
            private Pera peraNuolessa;

            public float PalautaHinta(int varsiPituus, int peraHinta, int karkiHinta)
            {
                float hinta = varsiPituus * 0.05f+peraHinta+karkiHinta;
                return hinta;
            }

            public void SetVarsiPituus(int varsiPituus) { _varsiPituus= varsiPituus; }
            public int GetVarsiPituus() { return _varsiPituus; }


            public void SetPeraHinta(int peraHinta) { _peraHinta = peraHinta; }
            public int GetPeraHinta() { return _peraHinta; }

            public void SetKarkiHinta(int karkiHinta) { _karkiHinta = karkiHinta; }
            public int GetKarkiHinta() { return _karkiHinta; }

        }
        public enum Pera {Lehti, kanansulka, kotkansulka };
        public enum Karki{Puu, Teräs, Timantti};


    }
}

