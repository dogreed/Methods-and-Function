using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace he
{
	class Look
	{

		// calcualtor usinmg methods, lets check the prime number

		static void primenumberchecker(int num)
		{
			bool isprimenumber = true;
			if (num <= 1)
			{
				isprimenumber = false;
			}
			else
			{

				for (int i = 2; i <= num / 2; i++)
				{

					if (num % i == 0)
					{
						isprimenumber = false;
						break;
					}

				}
			}
			if (isprimenumber)
			{
				Console.WriteLine("its a prime number " + num);
			}
			else
			{
				Console.WriteLine("its not a prime number" + num);
			}
		}
		

		public static void Main(string[] args)
		{

			Console.WriteLine("Prime Number Checker");
			Console.WriteLine("Enter a number:");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("ayoooo");
			primenumberchecker(num1);
		}
	}

}