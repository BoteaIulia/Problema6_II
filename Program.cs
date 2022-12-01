using System;

public static class Globals
{
	internal static void Main()
	{
		int n;
		int x;
		int ok = 1;
		int y;
		n = Convert.ToInt32(Console.ReadLine());
		x = Convert.ToInt32(Console.ReadLine());
		for (int i = 1; i < n; i++)
		{
			y = Convert.ToInt32(Console.ReadLine());
			if (x > y)
			{
				ok = 0;
				x = y;
			}
			Console.Write("Secventa e in ordine crescatoare" + ok + " ");


		}
	}
}