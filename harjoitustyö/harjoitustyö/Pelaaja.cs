using System;

public class Pelaaja
{
    public float dmg;
    public float health;
    public float armor;
    public int varustepaikat;
    public float raha;
    private int currentMäärä = 0;
    public Tavara[] tavaroita;

    public Pelaaja(float dmg, float health, float armor, int varustepaikat, float raha)
    {
        this.dmg = dmg;
        this.health = health;
        this.armor = armor;
        this.varustepaikat = varustepaikat;
        this.raha = raha;
        tavaroita = new Tavara[varustepaikat];
        
    }
    public void Lisää(Tavara tavara)
    {
        tavaroita[currentMäärä] = tavara;
        currentMäärä++;

    }
    public void Osto(float hinta)
    {
        raha -= hinta;
    }
}
