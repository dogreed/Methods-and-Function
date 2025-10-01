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


		static int reversenumber(int n) {
			int result = 0;
			while (n > 0)
			{ 
				//now just usinf=g formula for to reverse a number 
				result = result *10 + n % 10;


				n /= 10;

			}
			return result;
		}

		static int sumofall(int n)
		{
			int result = 0;
			int i =0;
			for ( i = 0; i<=n; i++)
			{
				result = result + i;
			}
			
			return result;
		}

		static int Fibonacchi(int n)
		{
			int a = 1;
			int b = 0;
			int temp = 0;
			for(int i = 0; i < n; i++)
			{
				 temp = a+b;
				a = b;
				b = temp;
				Console.WriteLine(temp);
			}

			return temp;
		}

		//fibonachi series

		public static void Main(String[] args)
		{
			// now lets make a condition where user can choose the value anmd calcuate the given thing sthey wanr
			bool again = true;
			while (again)
			{
				Console.WriteLine("what are u finding");
				Console.WriteLine("1.prime number ");
				Console.WriteLine("2.factorial number ");
				Console.WriteLine("3.reverse number ");
				Console.WriteLine("4.sum of number ");
				Console.WriteLine("5.Fibonacchi number ");

				int userchoice = Convert.ToInt32(Console.ReadLine());

				switch (userchoice)
				{
					case 1:
						Console.WriteLine("Prime Numeber");
						int usernumber = Convert.ToInt32(Console.ReadLine());
						bool result = PrimeChecker(usernumber);
						Console.WriteLine(result);
						break;

					case 2:
						Console.WriteLine("Factorial Number");
						int userfactnumber = Convert.ToInt32(Console.ReadLine());
						int factresult = factorialnuber(userfactnumber);
						Console.WriteLine(factresult);
						break;
					case 3:
						Console.WriteLine("reverse number");
						int userreversenumber = Convert.ToInt32(Console.ReadLine());
						int reverseresult = reversenumber(userreversenumber);
						Console.WriteLine(reverseresult);
						break;
					case 4:
						Console.WriteLine("sum of all number");
						int usersumofnumber = Convert.ToInt32(Console.ReadLine());
						int sumresult = sumofall(usersumofnumber);
						Console.WriteLine(sumresult);
						break;
					case 5:
						Console.WriteLine("Fibonacchi number");
						int userfibonacchinumber = Convert.ToInt32(Console.ReadLine());
						int fibonacchiresult = Fibonacchi(userfibonacchinumber);
						
						break;
					default:
						Console.WriteLine("invalid input");
						break;
				}

				Console.WriteLine("Do you want to continu again, press Y key for yes and click n or press any button:");
				if (Console.ReadLine().ToLower() != "y")
				{
					again = false;
				}
				else
				{
					again = true;
				}

			}


		}
	}
}