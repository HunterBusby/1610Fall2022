using System;
					
public class Program
{
	public Damage ultrabomb;
	public PowerUp damagePowerUp;
	public Enemypower enemypower;
	
	public void Main()
	{
		ultrabomb = new Damage();
		damagePowerUp = new PowerUp();
		enemypower = new Enemypower();

		ultrabomb.firePower += damagePowerUp.powerLevel;
		Console.WriteLine("Don't forget to use your " + ultrabomb.weaponName + "." );
		Console.WriteLine(enemypower.enemyname  + " has a level " + enemypower.powerLevel + " defense.");
		Console.WriteLine("The " + ultrabomb.weaponName + " will do "+ ultrabomb.firePower / enemypower.powerLevel + "HP damage to those enemies.");
		
	}
}

public class Damage {
	public int ammoCount = 10;
	public string weaponName = "Ultrabomb";
	public float firePower = 15.5f;
}

public class PowerUp {
	public float powerLevel =4.5f;
}
public class Enemypower {
	public int powerLevel =2;
	public string enemyname = "Stoic defender";
}
