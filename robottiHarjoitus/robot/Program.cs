namespace robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string käsky;
            Robotti robotti= new Robotti();
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Mikä komento syötetään robotille? Vaihtoehdot: " +
                    "Käynnistä, Sammuta, Ylös, Alas, Oikea, Vasen.");
                käsky= Console.ReadLine();
                if (käsky == "sammuta")
                {
                    robotti.Käskyt[i] = new Sammuta();
                }
                if (käsky == "käynnistä")
                {
                    robotti.Käskyt[i] = new Käynnistä();
                }
                if (käsky == "ylös")
                {
                    robotti.Käskyt[i] = new YlösKäsky();
                }
                if (käsky == "alas")
                {
                    robotti.Käskyt[i] = new AlasKäsky();
                }
                if (käsky == "vasen")
                {
                    robotti.Käskyt[i] = new VasenKäsky();
                }
                if (käsky == "oikea")
                {
                    robotti.Käskyt[i] = new OikeaKäsky();
                }
            }
            robotti.Suorita();
        }
        public class Robotti
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool OnKäynnissä { get; set; }
            public IRobottiKäsky[] Käskyt { get; } = new IRobottiKäsky[3];

            public void Suorita()
            {
                foreach (IRobottiKäsky käsky in Käskyt)
                {
                    käsky.Suorita(this);
                    Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
                }
            }
        }
        public interface IRobottiKäsky
        {

            void Suorita(Robotti robotti);
        }
        public class Sammuta : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                Console.WriteLine("Sammutus");
                robotti.OnKäynnissä = false;
            }
        }
        public class Käynnistä : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                Console.WriteLine("Käynnistys");
                robotti.OnKäynnissä = true;
            }
        }
        public class YlösKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    Console.WriteLine("Ylös");
                    robotti.Y += 1;
                }
            }
        }
        public class AlasKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    Console.WriteLine("Alas");
                    robotti.Y -= 1;
                }
            }
        }
        public class VasenKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    Console.WriteLine("Vasen");
                    robotti.X -= 1;
                }
            }
        }
        public class OikeaKäsky : IRobottiKäsky
        {
            public void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    Console.WriteLine("Oikea");
                    robotti.X += 1;
                }
            }
        }




    }
}