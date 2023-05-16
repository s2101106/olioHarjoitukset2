using System;
public class Vastustaja
{
    Random random= new Random();
	public float dmg;
	public float health;
    public float palkkio;
	public Vastustaja(float dmg, float health, float palkkio)
	{
		this.dmg = dmg;
		this.health = health;
        this.palkkio=palkkio;
	}
    public float Damage()
    {
        return random.Next(1, (int)dmg);
    }
}
public class Limamonsteri : Vastustaja
{
	public Limamonsteri():base(1f,45f, 20f) { }
    public override string ToString()
    {

        return "Kohtaat limamonsterin! Se on valtava, kömpelö ja ei tee paljoa vahinkoa!";
    }
}
public class KyborgiIlves : Vastustaja
{
    public KyborgiIlves() : base(5f, 20f, 30f) { }
    public override string ToString()
    {

        return "Kohtaat kyborgi-ilveksen! Se on keskikokoinen, ketterä ja tekee tuntuvasti vahinkoa!";
    }

}
public class HerraHarhautus : Vastustaja
{
    public HerraHarhautus() : base(10f, 5f, 40f) { }
    public override string ToString()
    {

        return "Kohtaat herra harhautuksen! Se on pieni, harhaanjohtava ja tekee paljoa vahinkoa!";
    }
}