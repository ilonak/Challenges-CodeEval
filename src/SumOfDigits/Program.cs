using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SumOfDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = "D:/Training/Challenges-CodeEval/src/SumOfDigits/input-text.txt";
			GetSumOfDigits(path);
			Console.ReadLine();
		}

		static void GetSumOfDigits(string path)
		{
			try
			{
				StreamReader reader = new StreamReader(path);
				string line;

				while ((line = reader.ReadLine()) != null)
				{
					if (line != "")
					{
						int sum = 0;
						bool parsed = true;
						int c = 0;

						while ((c <= line.Length - 1) && (parsed))
						{
							int digit;
							parsed = Int32.TryParse(line[c].ToString(), out digit);

							if (!parsed)
							{
								parsed = false;
								Console.WriteLine("Input string {0} is not in a correct format.", c);
								sum = 0;
							}
							else
							{
								sum = sum + digit;
							}
							c++;
						}
						Console.WriteLine("The sum is {0}", sum);
					}
				}
			}


			catch (Exception e)
			{
				Console.WriteLine("Error during execution.");
				Console.WriteLine(e.Message);
			}
		}
	}
}
