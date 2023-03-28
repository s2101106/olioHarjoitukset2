namespace reppu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tavara>tavarat= new List<Tavara>();
            Reppu reppu= new Reppu(20f,30f,10);
            string input;
            
            while (true) 
            {
                if(reppu.tavaroita!=null)
                {
                    Console.WriteLine($"Repussa on tällä hetkellä {reppu.currentMäärä}" +
                        $"/{reppu.maxMäärä} slottia, {reppu.currentKanto}/{reppu.maxKanto} painoa," +
                        $"{reppu.currentTilavuus}/{reppu.maxTilavuus} tilaa");
                }
                Console.WriteLine("Mitä haluat?");
                Console.WriteLine("1 - Nuoli");
                Console.WriteLine("2 - Jousi");
                Console.WriteLine("3 - Köysi");
                Console.WriteLine("4 - Vettä");
                Console.WriteLine("5 - Ruokaa");
                Console.WriteLine("6 - Miekka");
                input = Console.ReadLine();
                if(input=="1") 
                {
                    Nuoli nuoli= new Nuoli();
                    reppu.Lisää(nuoli);
                    
                }
                if (input == "2")
                {
                    Jousi jousi = new Jousi();
                    reppu.Lisää(jousi);
                }
                if (input == "3")
                {
                    Köysi köysi = new Köysi();
                    reppu.Lisää(köysi);
                }
                if (input == "4")
                {
                    Vesi vesi = new Vesi();
                    reppu.Lisää(vesi);
                }
                if (input == "5")
                {
                    Ruoka_annos ruoka = new Ruoka_annos();
                    reppu.Lisää(ruoka);
                }
                if (input == "6")
                {
                    Miekka miekka = new Miekka();
                    reppu.Lisää(miekka);
                }
            }
        }
    }
    public class Reppu
    {
        public float maxTilavuus;
        public float maxKanto;
        public int maxMäärä;
        public Tavara[] tavaroita;
        public int currentMäärä = 0;
        public float currentTilavuus=0f;
        public float currentKanto=0f;
        public Reppu(float maxTilavuus, float maxKanto, int maxMäärä)
        {
            this.maxTilavuus = maxTilavuus;
            this.maxKanto = maxKanto;
            this.maxMäärä = maxMäärä;
            tavaroita = new Tavara[maxMäärä];
        }
        public bool Lisää(Tavara tavara)
        {
            if (currentMäärä + 1 > maxMäärä||currentKanto+tavara.paino>maxKanto||currentTilavuus+tavara.tilavuus>maxTilavuus)
            {
                return false;
            }
            else
            {
                tavaroita[currentMäärä] = tavara;
                currentTilavuus+= tavara.tilavuus;
                currentKanto += tavara.paino;
                currentMäärä++;
                return true;
            }

        }

    }
    public class Tavara
    {
        public float paino { get; set; }
        public float tilavuus { get; set; }

        public Tavara(float paino, float tilavuus)
        {
            this.paino = paino;
            this.tilavuus = tilavuus;
        }
    }
    public class Nuoli : Tavara
    {   
        public Nuoli():base(0.1f,0.05f){ }   
    }
    public class Jousi : Tavara
    {
        public Jousi() : base(1f, 4f) { }
    }
    public class Köysi : Tavara
    {
        public Köysi() : base(1f, 1.5f) { }
    }
    public class Vesi : Tavara
    {
        public Vesi() : base(2f, 2f) { }
    }
    public class Ruoka_annos : Tavara
    {
        public Ruoka_annos() : base(1f, 0.5f) { }
    }
    public class Miekka : Tavara
    {
        public Miekka() : base(5f, 3f) { }
    }

}