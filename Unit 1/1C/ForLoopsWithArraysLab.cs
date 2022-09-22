using System;
					
public class Program
{
	public static void Main()
	{
		weapon[] murderweapon = {new weapon (), new weapon(), new weapon()};
		murderweapon[1].weaponName = "Rope";
		murderweapon[2].weaponName = "Fridge";
		
		for(var i=0;i<murderweapon.Length;i++) {
			murderweapon[i].victimCount = 3;
		}
		
		foreach(var item in murderweapon){
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.victimCount);
		} 
	}
}
public class weapon {
	public string weaponName = "Chopsticks";
	public int victimCount = 1;
}