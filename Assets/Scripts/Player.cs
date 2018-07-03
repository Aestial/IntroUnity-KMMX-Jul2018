// Jaime 
// 2018

public class Player
{
	bool isDead = false;
	private int numItems = 400;
	// private long numBactery = 0;
	private float health = 1.0f;
	// private double mana = 0.0;
	private new string name = "Player";
	private string clanName = "Gryffindor";

	// Propierties
	public float Health
	{
		get {return health;}
		set {health = value;}
	}

	public void Damage()
	{
		health = health - 0.1f;
	}
}