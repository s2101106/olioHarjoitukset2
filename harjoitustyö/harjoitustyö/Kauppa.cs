using System;

public class Kauppa
{
    public List <Tavara> varasto=new List<Tavara>();
    public Kauppa(Tavara tavara1, Tavara tavara2, Tavara tavara3)
    {
        varasto.Add (tavara1);
        varasto.Add(tavara2);
        varasto.Add(tavara3);


    }
    public void Shoppailu(Pelaaja pelaaja)
    {
        string input;   
        Console.WriteLine($"Tälläistä olisi tarjolla tänään! Sinulla on {pelaaja.raha} kolikkoa");
        foreach (Tavara esine in varasto) 
        {
            Console.WriteLine($"{esine.ToString()}");
        }
        Console.WriteLine("Mitä haluaisit?");
        input = Console.ReadLine();
        foreach (Tavara esine in varasto)
        {
            if (input == esine.id && pelaaja.raha>=esine.hinta)
            {
                if (esine.id == "1") { esine.health = 10f; }
                if (esine.id != "!")
                {
                    esine.KäyttöönOtto(pelaaja, esine);
                    varasto.Remove(esine);
                }
                pelaaja.Lisää(esine);
                pelaaja.Osto(esine.hinta);
                Console.WriteLine("Osto onnistui!");
                break;
            }
            if(input==esine.id&&pelaaja.raha<esine.hinta)
            {
                Console.WriteLine("Sinulla ei ole varaa");
                break;
            }
        }
    }
}
