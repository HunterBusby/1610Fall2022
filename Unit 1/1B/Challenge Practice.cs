using System;
					
public class Program
{
	int x = 20;
	int y = 18;
	public void Main()
	{
		Console.WriteLine("Welcome");
		Console.WriteLine("Check 1");
		CheckMath (1,2,3);
		Console.WriteLine("Check 2");
		CheckMath (3,2,1);
		Console.WriteLine("Check 3");
		CheckMath (5,5,1);
		Console.WriteLine("Check for XY");
		CheckXY ();
	}

	public void CheckMath (int value1, int value2, int value3) {
		if (value3 > value2 ) {
			Console.WriteLine("greater than last number");
		} else {
			Console.WriteLine("Not greater than last number");
		}
		if (value1 > value2 ) {
			Console.WriteLine("greater than first number");
		} else {
			Console.WriteLine("Not greater than first number");
		}
		if (value3 == value2 ) {
			Console.WriteLine("Last is the same as middle");
		} else {
			Console.WriteLine("Last is not the same as middle");
		}
		if (value1 == value2 ) {
			Console.WriteLine("First is the same as middle");
		} else {
			Console.WriteLine("First is not the same as middle");
		}
	
	}
	
	public void CheckXY () {
	if ( x == y ) {
			Console.WriteLine("X is the same as Y");
		} else {
			Console.WriteLine("X is not the same as Y");
		}
	}
}