using System;

namespace LAB03_Group
{
	class Program
	{
		public static double transaction(double Bal, double amount)
		{
			double RecentAmount = 0.0;

			if ((amount < 0 && Bal > amount) || amount > 0)
				RecentAmount = amount;

			return RecentAmount;
		}

		public static void Main(string[] args)
		{
			double curBal = 45.32;

			Console.Write("Please enter a amount to update account by $");

			double amount = Int32.Parse(Console.ReadLine());

			Console.Write("\n");

			Console.Write("Customer\'s balance (before transaction) = $");

			Console.WriteLine(curBal + "\n");

			Console.Write("Requested update amount = $");

			Console.WriteLine(amount + "\n");


			double actAmount = transaction(curBal, amount);

			curBal += actAmount;

			Console.Write("Actual update amount = $");
			Console.WriteLine(actAmount + "\n");
			Console.Write("Customer\'s balance (after transaction) = $");
			Console.WriteLine(curBal + "\n");

			Console.WriteLine("\nThank you and good-bye!\n");
		}
	}

}