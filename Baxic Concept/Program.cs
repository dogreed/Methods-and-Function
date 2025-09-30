namespace primenumber
{
	class Prime
	{

		private static bool PrimeChecker(int usernumber)
		{
			bool isPrime = true;
			if (usernumber <= 1)
			{
				return isPrime = false;

			}
			else
			{
				for (int i = 2; i <= usernumber / 2; i++)
				{
					if (usernumber % i == 0)
					{
						return isPrime = false;
						break;
					}

				}

			}

			if (isPrime)
			{
				return isPrime = true;
			}
			else
			{
				
				Console.WriteLine("its not a prime number " + usernumber);
			}

			return isPrime;
		}

		static int factorialnuber(int n)
		{
			int result = 1;
			for (int i = 1; i <= n; i++)
			{

				result = result * i;
			}
			return result;
		}

		public static void Main(String[] args)
		{
			//  so now we try to findl prime number
			Console.Write("Enter the number u wnt fing the factorial : ");
			int usernumber = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine("The factorial number is " + factorialnuber(usernumber) ); 
			
		
		}
	}
}