using System;
					
public class Program
{
	public Skeksis SkekSa; 
	public Skeksis SkekLo;
	public Gametime stateTime;
	
	public void Main()
	{
		SkekSa = new Skeksis();
		SkekLo = new Skeksis();
		
		stateTime = new Gametime () ;
		stateTime.currenttime = Gametime.Time.Evening;
		stateTime.CheckTime();
		
		string enemy1 = "SkekSka";
		SkekSa.health = 50;
		SkekSa.powerLevel = 5;
		SkekSa.specialPower = 15.5f;
		
		string enemy2 = "SkekLo";
		SkekLo.health = 40;
		SkekLo.powerLevel = 4;
		SkekLo.specialPower = 10.5f;
		
		Console.WriteLine("You have encountered a " + SkekSa.UserName);
		Console.WriteLine("");
		Console.WriteLine(enemy1 + " has (" + SkekSa.health + ") health.");
		Console.WriteLine(enemy1 + " is level (" + SkekSa.powerLevel + ")");
		Console.WriteLine(enemy1 + "'s Special power does (" + SkekSa.specialPower + ") damage.");
		Console.WriteLine("");
		Console.WriteLine(enemy2 + " has (" + SkekSa.health + ") health.");
		Console.WriteLine(enemy2 + " is level (" + SkekSa.powerLevel + ")");
		Console.WriteLine(enemy2 + "'s Special power does (" + SkekSa.specialPower + ") damage.");
	}
}
public class Skeksis
{
	public int health;
	public int powerLevel;
	public float specialPower;
	public string UserName = "Skeksis";
}

public class Gametime {

	public enum Time {
		Morning,
		Miday,
		Evening
	}
	public Time currenttime = Time.Morning;
	
	public void CheckTime () {
		switch (currenttime){
			case Time.Morning:
				Console.WriteLine("Good morning,");
				break;
			case Time.Miday:
				Console.WriteLine("Good afternoon,");
				break;
			case Time.Evening:
				Console.WriteLine("Good evening,");
				break;
			default:
				Console.WriteLine("Hello");
				break;
		
		}
	
	}
}