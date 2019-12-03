using System;

namespace Lab04
{
	class Program
	{
		public static double average(int n1, int n2)
		{
			return (n1 + n2) / 2.0;
		}

		static double average(int a, int b, int c)
		{
			return (a + b + c) / 3.0;
		}

		static double average(double a, double b)
		{
			return (a + b) / 2.0;
		}

		static double average(double a, double b, double c)
		{
			return (a + b + c) / 3.0;
		}

		public static void Main(String[] args)
		{

			int a = 1, b = 3, c = 5;

			double x = 2.2, y = 4.4, z = 6.6, ans;

			ans = average(a, b);

			Console.WriteLine("\naverage(a, b) = " + ans);

			ans = average(a, b, c);

			Console.WriteLine("\naverge(a, b, c) = " + ans);

			ans = average(x, y);

			Console.WriteLine("\naverage(x, y) = " + ans);

			ans = average(x, y, z);

			Console.WriteLine("\naverage(x, y, z) = " + ans);
		}

	}
}


//Q/A
//1.Do you really need the int parameter version(s)ofaverage,and why?
//Int parameter version helps us to give reference to the name space on the code so yes we need it.
//Without the defination we cannot able to run the code

//2.Do you really need the three parameter version of average,i.e.is average(average(a, b),c)== average(a, b, c),and why?
//We need the three parameter for the average of a,b,c because 
//without the three different numbers we are unable to calculate the average mean of numbers on the coding 
//as the average three diffferent numbers will have different value than the average of two numbers and a third number.
//There is difference in the average(average(a, b), c) and average(a, b, c).

//3.Is average(1,2.0,3)legal,and if so which version is used,and why?
//The average(1,2.0,3) if definately legal.
//The average(double a, double b, double c) version is used because  in a double argument we can only use this method.