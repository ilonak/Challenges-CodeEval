using System;

namespace MultiplicationTable
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintMultiplTable();
			Console.ReadLine();
		}
		static void PrintMultiplTable()
		{
 			int[,] MultiplTable = new int[12,12];

			for (int j = 0; j < 12; j++)
			{
				for (int i = 0; i < 12; i++)
				{
					MultiplTable[i,j] = (j+1)*(i+1);
					string result = (MultiplTable[i, j]).ToString();
					if (i != 0)
						Console.Write(string.Format("{0,4}",result));
					else
						Console.Write(string.Format("{0}", result));
//					Console.Write(result.PadLeft(4));
				}
				Console.WriteLine();
			}
		}
	}
}
