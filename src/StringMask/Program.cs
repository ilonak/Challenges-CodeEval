using System;
using System.IO;

namespace StringMask
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				ProcessFile(args[0], Console.Write);
				Console.ReadLine();
			}
		}

		private static void ProcessFile(string path, Action<string> Write)
		{
			try
			{
				StreamReader sr = new StreamReader(path);
				string line = "";
				while ((line = sr.ReadLine()) != null)
				{
					if (!String.IsNullOrWhiteSpace(line))
					{
						char[] delimiter = { ' ' };
						string[] separatedLine = line.Split(delimiter);
						string words = separatedLine[0];
						string code = separatedLine[1];

						for (int i = 0; i < words.Length; i++)
						{
							string a = words[i].ToString();
							if ((code[i].ToString()).Equals("1"))
							{
								a = a.ToUpper();
								Write(a);
							}
							else
							{
								Write(a);
							}
						}
						Write(Environment.NewLine);
					}
				}
			}
			catch (Exception e)
			{
				Write(e.ToString());
			}
		}
	}
}
