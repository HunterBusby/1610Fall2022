using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero tank;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		tank= new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroTwo.specialPower = 9.5f;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.specialPower = 7.5f;
		
		tank.health = 5;
		tank.powerLevel = 3;
		tank.specialPower = 12.5f;
		
		Console.WriteLine("HeroOne health (" + heroOne.health + ")");
		Console.WriteLine("HeroOne Power level (" + heroOne.powerLevel + ")");
		Console.WriteLine("HeroOne Special power (" + heroOne.specialPower + ")");
		
		Console.WriteLine("HeroTwo health (" + heroTwo.health + ")");
		Console.WriteLine("HeroTwo Power level (" + heroTwo.powerLevel + ")");
		Console.WriteLine("HeroTwo Special power (" + heroTwo.specialPower + ")");
		
		Console.WriteLine("Tank health (" + tank.health + ")");
		Console.WriteLine("Tank Power level (" + tank.powerLevel + ")");
		Console.WriteLine("Tank Special power (" + tank.specialPower + ")");
	}
}
public class Hero {
	public int health;
	public int powerLevel;
	public float specialPower;
}