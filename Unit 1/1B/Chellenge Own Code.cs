using System;
					
public class Program
{
	public int playerlvl = 3;
	public Skeksis SkekSa; 
	public Skeksis SkekLo;
	public Gametime stateTime;
	public Condition rundialogue;
	
	public void Main()
	{
		rundialogue = new Condition ();
		SkekSa = new Skeksis();
		SkekLo = new Skeksis();
		
		string enemy1 = "SkekSka";
		SkekSa.health = 50;
		SkekSa.powerLevel = 5;
		SkekSa.specialPower = 15.5f;
		
		string enemy2 = "SkekLo";
		SkekLo.health = 40;
		SkekLo.powerLevel = 4;
		SkekLo.specialPower = 10.5f;
		
		stateTime = new Gametime () ;
		stateTime.currenttime = Gametime.Time.Evening;
		stateTime.CheckTime();
		
		Console.WriteLine("You have encountered a " + SkekSa.UserName);
		Console.WriteLine("");
		Console.WriteLine(enemy1 + " has (" + SkekSa.health + ") health.");
		Console.WriteLine(enemy1 + " is level (" + SkekSa.powerLevel + ")");
		Console.WriteLine(enemy1 + "'s Special power does (" + SkekSa.specialPower + ") damage.");
		Console.WriteLine("");
		Console.WriteLine(enemy2 + " has (" + SkekLo.health + ") health.");
		Console.WriteLine(enemy2 + " is level (" + SkekLo.powerLevel + ")");
		Console.WriteLine(enemy2 + "'s Special power does (" + SkekLo.specialPower + ") damage.");
		Console.WriteLine("");
		rundialogue.lvlcheck(playerlvl,SkekSa.powerLevel);
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
public class Condition{	
	public void lvlcheck (int value, int value2) {
		string result = (value > value2 ) ? "Ha, this enemy is no match" : "you should run. They look much thougher than you.";
		Console.WriteLine(result);
		}
	}