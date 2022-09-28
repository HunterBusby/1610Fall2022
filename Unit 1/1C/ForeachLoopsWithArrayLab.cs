using System;
					
public class Program
{
	public void Main()
	{
		string[] cars = {"Mustang", "Camero", "Hellcat", "Corvette", "Viper", "Mclaren"};
		foreach(var location in cars) {
			Console.WriteLine("I love my " + location + ".");
		}
	}
}