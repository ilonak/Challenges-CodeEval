using System;
using System.IO;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				ProcessFile(args[0], Console.Write);
			}
			Console.ReadLine();
		}

		private static void ProcessFile(string file, Action<string> Write)
		{
			try
			{
				string line;
				StreamReader sr = new StreamReader(file);
				while ((line = sr.ReadLine()) != null && !String.IsNullOrWhiteSpace(line))
				{
					Calculate(line, Console.Write);
				}
			}
			catch (Exception e)
			{
				Write(e.ToString());
			}
		}

		private static void Calculate(string line, Action<string> Write)
		{
			char[] delimiter = {' '};
			string[] inputNumbers = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

			int x = Int32.Parse(inputNumbers[0]);
			int y = Int32.Parse(inputNumbers[1]);
			int n = Int32.Parse(inputNumbers[2]);
			bool printed = false;
			for (int i = 1; i <= n; i++)
			{
				if (printed)
				{
					Write(" ");
				}
				if ((i % x == 0) && (i % y == 0))
				{
					Write("FB");
				}
				else if (i % x == 0)
				{
					Write("F");
				}
				else if (i % y == 0)
				{
					Write("B");
				}
				else
				{
					Write(i.ToString());
				}
				printed = true;
			}
			Write(Environment.NewLine);

		}
	}
}
