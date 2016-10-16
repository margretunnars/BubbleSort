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

				return number;
			}

			Console.Write("\n");


			foreach (int i in number)
			{
				Console.Write("{0}  ", i);
			}

		}

	}
}
