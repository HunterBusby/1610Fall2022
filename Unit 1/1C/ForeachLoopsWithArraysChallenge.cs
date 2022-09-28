using System;
					
public class Program
{
	public void Main()
	{
		string[] places = {"Kitchen", "Bathroom", "Bedroom", "Lounge", "Garden", "Attic"};
		foreach(var location in places) {
			Console.WriteLine("Did the murder occur in the " + location + "?");
		}
	}
}