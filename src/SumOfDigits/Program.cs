using System;
using System.IO;

namespace SumOfDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				GetSumOfDigits(args[0], Console.Write);
			}
			Console.ReadLine();
		}

		static void GetSumOfDigits(string path, Action<string> Write)
		{
			try
			{
				StreamReader reader = new StreamReader(path);
				string line;

				while ((line = reader.ReadLine()) != null)
				{
					if (!String.IsNullOrWhiteSpace(line))
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
								Write(string.Format("Input string {0} is not in a correct format.", line[c]));
								Write(Environment.NewLine);
								sum = 0;
							}
							else
							{
								sum = sum + digit;
							}
							c++;
						}
						if (parsed)
						{
							Write(string.Format("{0}", sum));
							Write(Environment.NewLine);
						}
					}
				}
			}
			catch (Exception e)
			{
				Write("Error during execution." + Environment.NewLine);
			}
		}
	}
}
