using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Words_in_file_reversed
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = "D:/Training/sum-of-primes/test-input.txt";

			PrintReversedWords(path);
			Console.ReadLine();
		}

		static void PrintReversedWords(string path)
		{

			try
			{
				string line;
				StreamReader reader = new StreamReader(path);
				string[] separator = { " ", ",", ".", "!", "?", ";", ":" };

				while ((line = reader.ReadLine()) != null)
				{
					if (line != "")
					{
						int i;
						string[] words = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
						i = words.Length -1;

						while (i >= 0)
						{
							Console.Write("{0}", words[i]);
							if (i != 0)
							{
								Console.Write(" ");
							}
							i--;
						}
						Console.Write("\n\r");
					}
				}
				reader.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read.");
				Console.WriteLine(e.Message);
 
			}
		}
	}
}