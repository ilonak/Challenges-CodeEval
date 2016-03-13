using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FindWriter
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				ProcessFile(args[0]);
				Console.ReadLine();
			}
		}

		static void ProcessFile(string file)
		{
			string line = "";
			StreamReader sr = new StreamReader(file);
			while ((line = sr.ReadLine()) != null)
			{
				PrintWriter(line, Console.Write);
			}
		}

		public static void PrintWriter(string line, Action<string> Write)
		{
			if (!String.IsNullOrWhiteSpace(line))
			{
				List<string> listCodedChars = new List<string>();
				string[] delimiters = { " " };
				int indexPipe = 0;
				bool pipePresent = false;

				foreach (char c in line)
				{
					if (!pipePresent)
					{
						if ((c.ToString()) != "|")
						{
							listCodedChars.Add(c.ToString());
						}
						else
						{
							pipePresent = true;
							indexPipe = line.IndexOf(c.ToString());
						}
					}
				}
				string stringAfterPipe = line.Substring(indexPipe + 1);
				string[] arrayKeys = stringAfterPipe.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

				foreach (string i in arrayKeys)
				{
					Write(listCodedChars[Int32.Parse(i) - 1]);
				}
				Write(Environment.NewLine);
				//Console.ReadLine();
			}
		}
	}
}
