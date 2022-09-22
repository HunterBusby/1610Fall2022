using System;
					
public class Program
{
   public void Main(string[] args)
    {
      int i = 1;
      while (i < 6) 
      {
        Console.WriteLine(i);
        i++;
      }
	   Console.WriteLine("");
	   int r = 1;
      do 
      {
        Console.WriteLine(r);
        r++;
      }
      while (r < 11);
	   Console.WriteLine("");
      for (int Q = 11; Q < 11; Q--) 
      {
        Console.WriteLine(Q);
      }    
		Console.WriteLine("");
		for (int s = 1; s <= 3000; s = s * 3)
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