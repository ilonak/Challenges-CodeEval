using System;
using System.IO;

namespace UniqueElements
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

		private static void ProcessFile(string path, Action<string> Write)
		{
			try
			{
				StreamReader sr = new StreamReader(path);
				string line;
				while ((line = sr.ReadLine()) != null && !String.IsNullOrWhiteSpace(line))
				{ 
					char delimiter = ',';
					string[] numbers = line.Split(delimiter);
					Write(numbers[0]);

					for (int i = 1; i < numbers.Length; i++)
					{
						if (numbers[i] != numbers[i - 1])
						{
							Write("," + numbers[i]);
						}
					}
					Write(Environment.NewLine);
				}
			}
			catch (Exception e)
			{
				Write("File cannot be processed" + e);
			}
		}
	}
}
