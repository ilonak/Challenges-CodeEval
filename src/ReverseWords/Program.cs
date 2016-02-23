using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReverseWords
{
	public class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
				PrintReversedWords(args[0], Console.Write);
		}

		public static void PrintReversedWords(string path, Action<string> Write)
		{
			try
			{
				string line;
				StreamReader reader = new StreamReader(path);
				string[] separator = { " ", ",", ".", "!", "?", ";", ":" };

				while ((line = reader.ReadLine()) != null)
				{
					//if (line != "" && line != " ")
					if (!String.IsNullOrWhiteSpace(line))
					{
						int i;
						string[] words = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
						i = words.Length -1;

						while (i >= 0)
						{
							Write(string.Format("{0}", words[i]));
							if (i != 0)
							{
								Write(" ");
							}
							i--;
						}
						Write(Environment.NewLine);
					}
				}
				//Console.ReadLine();
				reader.Close();
			}
			catch (Exception e)
			{
				Write("The file could not be read." + Environment.NewLine);
 			}
		}
	}
}