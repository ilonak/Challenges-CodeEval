using System;
using System.IO;

namespace RightmostChar
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
						char[] delimiter = {','};
						string[] separatedLine = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
						string words = separatedLine[0];
						string character = separatedLine[1];
						int position = words.LastIndexOf(character);

						Write(position.ToString());
						Write(Environment.NewLine);
					}
				}
			}
			catch(Exception e)
			{
				Write(e.ToString());
			}
		}
	}
}
