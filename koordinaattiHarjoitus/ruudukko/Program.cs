namespace ruudukko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koordinaatti koordinaatisto= new Koordinaatti(1,1);
            string xInput;
            string yInput;
            while (true)
            {
                Console.WriteLine("Anna X koordinaatti");
                xInput = Console.ReadLine();
                Console.WriteLine("Anna Y koordinaatti");
                yInput = Console.ReadLine();
                if (koordinaatisto.onkoVieressa(Convert.ToInt32(xInput),Convert.ToInt32(yInput))==true)
                {
                    Console.WriteLine($"Koordinaatti {xInput},{yInput} " +
                    $"on koordinaatin {koordinaatisto._x} {koordinaatisto._y} vieressä");
                }
            
            }

        }
        public struct Koordinaatti
        {
            public int _x { get; private set; }
            public int _y { get; private set; }
            public Koordinaatti(int x,int y)
            {
                _x = x;
                _y = y;
            }
            public bool onkoVieressa(int x, int y)
            {
                if (x-1==_x ||x+1==_x)
                {
                    return true;
                }
                if (y-1==_y||y+1==_y)
                {
                    return true;
                }
                return false;
            }
        }
    }
}