using System;

public class Reppu
{
	public int varustepaikat;
	public float raha;
	private int currentMäärä = 0;
	private Tavara[] tavaroita;
	public Reppu(int varustepaikat, float raha)
	{
		this.varustepaikat = varustepaikat;
		this.raha = raha;
		tavaroita = new Tavara[varustepaikat];
	}
	public void Lisää(Tavara tavara)
	{
		tavaroita[currentMäärä] = tavara;
		currentMäärä++;
	}
	public void Osto(int hinta) 
	{
		raha -= hinta;
	}
}
