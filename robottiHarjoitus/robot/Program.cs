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
            public RobottiKäsky[] Käskyt { get; } = new RobottiKäsky[3];

            public void Suorita()
            {
                foreach (RobottiKäsky käsky in Käskyt)
                {
                    käsky.Suorita(this);
                    Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
                }
            }
        }
        public abstract class RobottiKäsky
        {

            public abstract void Suorita(Robotti robotti);
        }
        public class Sammuta : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                Console.WriteLine("Sammutus");
                robotti.OnKäynnissä = false;
            }
        }
        public class Käynnistä : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                Console.WriteLine("Käynnistys");
                robotti.OnKäynnissä = true;
            }
        }
        public class YlösKäsky : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    Console.WriteLine("Ylös");
                    robotti.Y += 1;
                }
            }
        }
        public class AlasKäsky : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    Console.WriteLine("Alas");
                    robotti.Y -= 1;
                }
            }
        }
        public class VasenKäsky : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä == true)
                {
                    Console.WriteLine("Vasen");
                    robotti.X -= 1;
                }
            }
        }
        public class OikeaKäsky : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
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