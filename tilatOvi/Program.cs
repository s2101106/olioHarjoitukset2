namespace tilatOvi
{
    internal class Program
    {
        enum oviTila {auki, kiinni, lukossa }
        static void Main(string[] args)
        {
                oviTila nykyinenTila = oviTila.auki;
            while (true)
            {
                Console.WriteLine($"Ovi on {nykyinenTila}. Mitä haluat tehdä?");
                string action = Console.ReadLine();
                if(action=="sulje")
                {
                    if (nykyinenTila == oviTila.auki)
                    {
                        nykyinenTila = oviTila.kiinni;
                        continue;
                    }
                    
                }
                if (action == "lukitse")
                {
                    if (nykyinenTila == oviTila.kiinni)
                    {
                        nykyinenTila = oviTila.lukossa;                      
                        continue;
                    }
                }
                if(action == "poista lukitus")
                {
                    if (nykyinenTila == oviTila.lukossa)
                    {
                        nykyinenTila = oviTila.kiinni;
                        continue;
                    }
                }
                if (action == "avaa")
                {
                    if (nykyinenTila == oviTila.kiinni)
                    {
                        nykyinenTila = oviTila.auki;
                        continue;
                    }
                }
                //else
                //{
                  //  Console.WriteLine($"Et voi {action} ovea, joka on {nykyinenTila}");  
                //}
            }
        }
    }
}