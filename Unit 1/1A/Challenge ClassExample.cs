using System;
					
public class ClassExample
{
	
}

public class ClassWithVariables
{
	public int number = 2;
	public float row = 1.5f;
	public char Column = 'A';
	public string UserName = "Bob";
}
public class ClassWithFunctions
{
	public ClassWithVariables Variable;
	
	public void Main()
	{
		Variable = new ClassWithVariables();
		
		Variable.row *= Variable.number;
		Console.WriteLine("Running Function");
		Console.WriteLine("Would guest " + Variable.UserName + " From row " + Variable.row + " Column " + Variable.Column + " Please go to sector " + Variable.number);
		Console.WriteLine("If I multiplied my row with the sector I'm going to, I would get The answer "+ Variable.row * Variable.number);
	}
}