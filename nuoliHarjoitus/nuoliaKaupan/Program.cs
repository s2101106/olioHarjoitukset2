using System;

namespace nuoliaKaupan
{
    internal class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string nuoliValinta = "";
                Console.WriteLine("Haluatko valita valmisnuolen? y, or n ");
                string valinta=Console.ReadLine();
                if (valinta == "y")
                {
                    Console.WriteLine("Haluatko? a:Aloittelijanuolen b:Perusnuolen c:Eliittinuolen");
                    nuoliValinta=Console.ReadLine();
                    if(nuoliValinta== "a")
                    {
                        Console.WriteLine(Luokka.LuoAloittelijaNuoli()._palautaHinta);
                    }
                    if (nuoliValinta == "b")
                    {
                        Console.WriteLine(Luokka.LuoPerusNuoli()._palautaHinta);
                    }
                    if (nuoliValinta == "c")
                    {
                        Console.WriteLine(Luokka.LuoEliittiNuoli()._palautaHinta);

                    }
                    break;
                }
                Luokka nuoli= new Luokka();
                Console.Write("Minkälainen kärki (puu, teräs vai timantti):");
                string kärki=Console.ReadLine();
                if (kärki == "puu") 
                {
                    nuoli._karkiHinta=3;
                }
                if (kärki == "teräs")
                {
                    nuoli._karkiHinta = 5;
                }
                if (kärki == "timantti")
                {
                    nuoli._karkiHinta = 50;
                }

                Console.Write("Minkälainen perä (lehti, kanansulka vai kotkansulka):");
                string perä = Console.ReadLine();
                if (perä == "lehti")
                {
                    nuoli._peraHinta = 0;   
                }
                if (perä == "kanansulka")
                {
                    nuoli._peraHinta = 1;
                }
                if (perä == "kotkansulka")
                {
                    nuoli._peraHinta = 5;
                }

                Console.Write("Nuolen pituus (60-100cm):");
                string pituus = Console.ReadLine();
                nuoli._varsiPituus=Convert.ToInt32(pituus);


                Console.WriteLine(nuoli._palautaHinta);
            
            }
        }
        class Luokka
        {
            public int _varsiPituus { get; set; }
            public int _karkiHinta { get; set; }
            public int _peraHinta { get; set; }
            public float _palautaHinta { get=>_peraHinta+_karkiHinta+(_varsiPituus*0.05f); }
            public static Luokka LuoEliittiNuoli()
            {
                Luokka eliittiNuoli= new Luokka();
                eliittiNuoli._varsiPituus = 100;
                eliittiNuoli._karkiHinta= 50;
                eliittiNuoli._peraHinta= 5;
                return eliittiNuoli;
            }
            public static Luokka LuoAloittelijaNuoli()
            {
                Luokka aloittelijaNuoli= new Luokka();
                aloittelijaNuoli._varsiPituus = 70;
                aloittelijaNuoli._karkiHinta = 3;
                aloittelijaNuoli._peraHinta = 0;
                return aloittelijaNuoli;
            }
            public static Luokka LuoPerusNuoli()
            {
                Luokka perusNuoli = new Luokka();
                perusNuoli._varsiPituus = 85;
                perusNuoli._karkiHinta = 5;
                perusNuoli._peraHinta = 1;
                return perusNuoli;
            }

        }



    }
}

