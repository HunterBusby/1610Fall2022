using System;
					
public class Program
{
	public Weapon minigun;
	public PowerUp weaponPowerUp;
	
	public void Main()
	{
		minigun = new Weapon();
		weaponPowerUp = new PowerUp();
		
		minigun.ammoCount++;
		minigun.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine(minigun.weaponName + " has an ammo count of " + minigun.ammoCount + ".");
		Console.WriteLine("The firepower is now " + minigun.firePower + ", has increased.");
		
	}
}

public class Weapon {
	public int ammoCount = 10;
	public string weaponName = "Mini Gun";
	public float firePower = 11.5f;
}

public class PowerUp {
	public float powerLevel =2.5f;
}