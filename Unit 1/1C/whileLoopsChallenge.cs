using System;
					
public class Program
{
   public void Main(string[] args)
    {
      int a = 32;
      while (a < 43) 
      {
        Console.WriteLine(a);
        a++;
      }
	   Console.WriteLine("");
	   int b = 110;
      do 
      {
        Console.WriteLine(b);
        b++;
      }
      while (b < 121);
	   Console.WriteLine("");
      for (int c = 11; c < 11; c--) 
      {
        Console.WriteLine(c);
      }    
		Console.WriteLine("");
		for (int s = 1; s <= 50000; s = s * 4)
      {
        Console.WriteLine(s);
      } 
	   Console.WriteLine("");
	   string[] killers = {"leon", "mondo", "Celestia", "sakura", "Junko"};
      foreach (string w in killers) 
      {
        Console.WriteLine(w);
      }   
    }
 }