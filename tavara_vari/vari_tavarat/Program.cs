namespace vari_tavarat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class VaritettyTavara<T>
        {
            private Tavara<T> tavara;
            private T color;
            public VaritettyTavara(T tavara, T color)
            {
                this.color= color;
                this.tavara = tavara;
            }
            public void NaytaTavara()
            {
                Console.ForegroundColor=color;
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
            public Nuoli() : base(0.1f, 0.05f) { }
            public override string ToString()
            {
                return "Nuoli";
            }
        }
        public class Jousi : Tavara
        {
            public Jousi() : base(1f, 4f) { }
            public override string ToString()
            {
                return "Jousi";
            }
        }
        public class Köysi : Tavara
        {
            public Köysi() : base(1f, 1.5f) { }
            public override string ToString()
            {
                return "Köysi";
            }
        }
        public class Vesi : Tavara
        {
            public Vesi() : base(2f, 2f) { }
            public override string ToString()
            {
                return "Vesi";
            }
        }
        public class Ruoka_annos : Tavara
        {
            public Ruoka_annos() : base(1f, 0.5f) { }
            public override string ToString()
            {
                return "Köysi";
            }
        }
        public class Miekka : Tavara
        {
            public Miekka() : base(5f, 3f) { }
            public override string ToString()
            {
                return "Miekka";
            }
        }
    }
}