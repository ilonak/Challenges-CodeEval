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
			string line;

			StreamReader reader = new StreamReader(path);
			string[] separator = { " ", ",", ".", "!", "?", ";", ":" };

			while ((line = reader.ReadLine()) != null)
			{
				if (line != "")
				{
					string[] words = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);

					int i;
					i = words.Length - 1;
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


				//for (int i = words.Length - 1; i >= 0; i--)
				//{
				//	Console.WriteLine("{0}", );
				//}
			}
			sr.Close();
			Console.ReadLine();

		}
	}
}