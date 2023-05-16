namespace harjoitustyö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parannusjuoma potion=new Parannusjuoma();
            Miekka1 miekka=new Miekka1();
            Haarniska1 haarniska=new Haarniska1();
            Pelaaja pelaaja = new Pelaaja(5f,10f,0f,10,10f);
            Kauppa kauppa=new Kauppa(potion,miekka,haarniska);
            DMiekka dmiekka= new DMiekka();
            DHaarniska dHaarniska=new DHaarniska();
            pelaaja.Lisää(dmiekka);
            pelaaja.Lisää(dHaarniska);
            string input;
            Console.WriteLine("Hyvää päivää ritari!");
            
            while (true)
            {
                if(pelaaja.health<=0)
                {
                    Console.WriteLine("Hävisit pelin.");
                    break;
                }
                Console.WriteLine($"Sinulla on {pelaaja.raha} kolikkoa ja {pelaaja.health} terveyspistettä. Haluatko taistella vai vierailla kaupassa? (T), (K)");
                input=Console.ReadLine();
                if (input.ToLower() == "k")
                {
                    Kauppa(kauppa, pelaaja);
                }
                if (input.ToLower() == "t")
                {
                    Console.WriteLine("Valitse vastustajasi (1),(2),(3)");
                    input= Console.ReadLine();
                    if (input == "1")
                    {
                        Limamonsteri limis=new Limamonsteri();
                        Taistelu(limis, pelaaja);
                    }
                    if (input == "2")
                    {
                        KyborgiIlves ilves = new KyborgiIlves();
                        Taistelu(ilves, pelaaja);
                    }
                    if (input == "3")
                    {
                        HerraHarhautus herra = new HerraHarhautus();
                        Taistelu(herra, pelaaja);
                    }

                }



            }
        }
        static void Taistelu(Vastustaja vastustaja, Pelaaja pelaaja)
        {
            string input;
            float damage;
            bool onkoPotion=false;
            Console.WriteLine(vastustaja.ToString());
            while (vastustaja.health > 0&& pelaaja.health>0)
            {
                Console.WriteLine($"Ritari: {pelaaja.health} Vastustaja:{vastustaja.health}");
                Console.WriteLine("Hyökkäys vai Blokkaus? (H), (B)");
                input = Console.ReadLine();
                damage= vastustaja.Damage()*(1f-pelaaja.armor);
                if (input.ToLower() == "h")
                {
                    vastustaja.health -= pelaaja.dmg;
                    pelaaja.health -= damage;
                    Console.WriteLine($"Teit {pelaaja.dmg} pistettä vahinkoa!");
                    Console.WriteLine($"Sinuun tehtiin {damage} pistettä vahinkoa!");
                }
                if (input.ToLower()  == "b")
                {
                    Console.WriteLine($"Sinuun tehtiin { damage * 0.5} pistettä vahinkoa!");
                    pelaaja.health-=damage*0.5f;
                }
            }
            if (pelaaja.health <= 0)
            {
                foreach(Tavara esine in pelaaja.tavaroita)
                {
                    if (esine == null)
                    {
                        break;
                    }
                    if (esine.id == "1"&&esine.health>0)
                    {
                        pelaaja.health = 0;
                        Console.WriteLine($"Terveyspisteesi loppui, mutta sinulla on parannusjuoma repussa!");
                        esine.KäyttöönOtto(pelaaja, esine);
                        esine.health = 0f;
                        onkoPotion = true;
                        
                    }
                }
                if (onkoPotion == false)
                {
                    Console.WriteLine($"Hävisit taistelun!");
                    return;

                }
            }
            if (vastustaja.health <= 0)
            {
                Console.WriteLine($"Päihitit vastustajan viimeisellä iskulla! Palkkiosi: {vastustaja.palkkio} kultakolikkoa!");
                pelaaja.raha += vastustaja.palkkio;
                Console.WriteLine($"Sinulla on nyt {pelaaja.raha} kolikkoa!");
                return;

            }
        }
        public static void Kauppa(Kauppa kauppa, Pelaaja pelaaja)
        {
            kauppa.Shoppailu(pelaaja);
        }
    }
}