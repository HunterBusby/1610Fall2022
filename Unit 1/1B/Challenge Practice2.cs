using System;
					
public class Program
{
	public Gametime stateTime;
	
	public void Main()
	{
		stateTime = new Gametime () ;
		stateTime.currenttime = Gametime.Time.Evening;
		stateTime.CheckTime();
	}
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
				Console.WriteLine("Good morning");
				break;
			case Time.Miday:
				Console.WriteLine("Good afternoon");
				break;
			case Time.Evening:
				Console.WriteLine("Good evening");
				break;
		
		}
	
	}
}