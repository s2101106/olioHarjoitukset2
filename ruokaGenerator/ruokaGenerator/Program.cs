using System;
namespace ruokaGenerator
{
    internal class Programn
    {
        enum pääRaakaAine {nautaa, kanaa, kasviksia}
        enum lisukeAine {perunaa, riisiä, pastaa}
        enum kastikeAine {curry, hapanimelä, pippuri, chili}
        static void Main(string[] args)
        {
            
            (pääRaakaAine, pääRaakaAine, pääRaakaAine) pääraaka=(pääRaakaAine.nautaa, pääRaakaAine.kanaa, pääRaakaAine.kasviksia);
            (lisukeAine, lisukeAine, lisukeAine) lisuke = (lisukeAine.perunaa, lisukeAine.riisiä, lisukeAine.pastaa);
            (kastikeAine, kastikeAine, kastikeAine, kastikeAine) kastike = (kastikeAine.curry, kastikeAine.hapanimelä, kastikeAine.pippuri, kastikeAine.chili);
            (string annos1, string annos2, string annos3)[] LuoAnnokset()
            {
                return new (string, string, string)[3]
                {
                    ("","",""),
                    ("","",""),
                    ("","",""),

                };
            }
            Console.WriteLine(LuoAnnokset();
            Console.WriteLine($"Pääraaka-aine {pääraaka}:");
            string input1=Console.ReadLine();
            Console.WriteLine($"Lisuke {lisuke}:");
            string input2=Console.ReadLine();
            Console.WriteLine($"Kastike {kastike}:");
            string input3=Console.ReadLine();

            (string raaka, string lisu, string kastik) annos = (input1, input2, input3);
            Console.WriteLine($"{annos.raaka} ja {annos.lisu} {annos.kastik}lla");
            




        }



    }











}




