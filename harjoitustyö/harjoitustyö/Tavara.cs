using System;

public class Tavara : IConsumable
{
	private int tila;
	private float dmg;
	public float health;
	private float armor;
	public float hinta;
	public string id;
	public Tavara(int tila, float dmg, float health, float armor, float hinta, string id)
	{
		this.tila = tila;
		this.dmg = dmg;
		this.health = health;
		this.armor = armor;
		this.hinta = hinta;	
		this.id = id;
	}
	public void KäyttöönOtto(Pelaaja pelaaja, Tavara tavara)
	{
		pelaaja.dmg += tavara.dmg;
		pelaaja.health += tavara.health;
		pelaaja.armor += tavara.armor;
		pelaaja.varustepaikat -= tavara.tila;
	}

}
	public class Parannusjuoma : Tavara
	{
		public Parannusjuoma() : base(1,0f,10f,0f, 5f,"1") { }
		public override string ToString()
		{

			return $"1. Parannusjuoma, Hinta:{hinta}";
		}
	}
    public class Miekka1 : Tavara
    {
        public Miekka1() : base(1, 5f, 0f, 0f, 10f,"2") { }
		public override string ToString()
		{

			return $"2. Miekka, Hinta:{hinta}";
		}
    }
    public class Haarniska1 : Tavara
    {
        public Haarniska1() : base(1, 0f, 0f, 0.2f, 10f,"3") { }
		public override string ToString()
		{

			return $"3. Haarniska, Hinta:{hinta}";
		}
    }
	public class DMiekka : Tavara
	{
		public DMiekka() : base(1, 5f, 0f, 0f, 10f, "4") { }
		public override string ToString()
		{

			return $"Perusmiekka";
		}
	}
	public class DHaarniska : Tavara
	{
		public DHaarniska() : base(1, 0f, 0f, 0.2f, 10f, "5") { }
		public override string ToString()
		{

			return $"Perushaarniska";
		}
	}
public interface IConsumable
{
	public void KäyttöönOtto(Pelaaja pelaaja, Tavara tavara);
}
