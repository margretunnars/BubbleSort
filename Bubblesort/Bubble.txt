using System;

namespace Bubblesort
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] number = { 15, 68, 4, 19, 99, 52, 53, 36, 74, 1, 85 };

			foreach (int i in number) 
			{
				Console.Write("{0}  ", i);
			}

			Console.Write("\n");

			number = OrderAscending(number);


			foreach (int i in number)
			{
				Console.Write("{0}  ", i);
			}


		}
		public static int[] OrderAscending(int[] number)
		{
			// 1. swap ef gildi i er stærra en gildi i+1
			// 2. ef þú ferð í gegnum listann einu sinni er þá rétt að allur listinn sé raðaður?
			// 3. þá þarf að fara í gegnum listann þangað til að engu er breytt
			bool swapped = true;

			while (swapped == true)
			{
				swapped = false;
				for (int i = 0; i < number.Length - 1; i++)
				{
					if (number[i] > number[i + 1])
					{
						int temp = number[i];
						number[i] = number[i + 1];
						number[i + 1] = temp;

						swapped = true;

					}
				}
			}
			return number;
		}
	}
}
