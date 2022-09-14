using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		int sum1 = 100 + 50;
		int sum2 = sum1 + 250;
		int sum3 = sum2 + sum2;
		int x = 5;
		int y = 3; 
		Console.WriteLine(sum1);
		Console.WriteLine(sum2);
		Console.WriteLine(sum3);
		Console.WriteLine(x + y);
		Console.WriteLine(x - y);
		Console.WriteLine(x * y);
		Console.WriteLine(x / y);
		Console.WriteLine(x % y);
		Console.WriteLine(x++);
		Console.WriteLine(x--);
		Console.WriteLine(x == y);
		Console.WriteLine(x != y);
		Console.WriteLine(x > y);
		Console.WriteLine(x < y);
		Console.WriteLine(x >= y);
		Console.WriteLine(x <= y);
		Console.WriteLine(x < 5 &&  x < 10);
		Console.WriteLine(x < 5 || x < 4);
		Console.WriteLine(x < 5 && x < 10);
	}
}