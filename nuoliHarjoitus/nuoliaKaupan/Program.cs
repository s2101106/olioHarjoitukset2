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
                    nuoli.karkiNuolessa = Luokka.Karki.Puu;
                    nuoli.karkiHinta += 3;
                }
                if (kärki == "teräs")
                {
                    nuoli.karkiNuolessa = Luokka.Karki.Teräs;
                    nuoli.karkiHinta += 5;
                }
                if (kärki == "timantti")
                {
                    nuoli.karkiNuolessa = Luokka.Karki.Timantti;
                    nuoli.karkiHinta += 50;
                }

                Console.Write("Minkälainen perä (lehti, kanansulka vai kotkansulka):");
                string perä = Console.ReadLine();
                if (perä == "lehti")
                {
                    nuoli.peraNuolessa = Luokka.Pera.Lehti;
                    nuoli.peraHinta+= 0;   
                }
                if (perä == "kanansulka")
                {
                    nuoli.peraHinta += 1;
                    nuoli.peraNuolessa = Luokka.Pera.kanansulka;
                }
                if (perä == "kotkansulka")
                {
                    nuoli.peraHinta += 5;
                    nuoli.peraNuolessa = Luokka.Pera.kotkansulka;
                }

                Console.Write("Nuolen pituus (60-100cm):");
                string pituus = Console.ReadLine();
                nuoli.varsiPituus=Convert.ToInt32(pituus);
            

                Console.WriteLine(nuoli.PalautaHinta(nuoli.varsiPituus, nuoli.peraHinta, nuoli.karkiHinta));
            
            }
            


        }
        class Luokka
        {
            public int varsiPituus;

            public int karkiHinta;
            public int peraHinta;
            public enum Karki{Puu, Teräs, Timantti};
            public Karki karkiNuolessa;

            public enum Pera {Lehti, kanansulka, kotkansulka };
            public Pera peraNuolessa;

            public float PalautaHinta(int varsiPituus, int peraHinta, int karkiHinta)
            {
                float hinta = varsiPituus * 0.05f+peraHinta+karkiHinta;
                return hinta;
            }
                
        }


    }
}

