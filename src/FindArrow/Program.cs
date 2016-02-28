using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindArrow
{
	public class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
				AnalyzeFileForArrows(args[0], Console.Write);
		}

		public static void AnalyzeFileForArrows(string path, Action<string> Write)
		{
			try
			{
				string line;
				StreamReader reader = new StreamReader(path);
				//				string[] separator = { " ", ",", ".", "!", "?", ";", ":" };

				while ((line = reader.ReadLine()) != null)
				{
					int count = AnalyzeOneLine(line);
					Write(count.ToString());
					Write(Environment.NewLine);
					Console.ReadLine();
				}
				reader.Close();
			}
			catch (Exception e)
			{
				Write("The file could not be read." + Environment.NewLine);
			}
		}

		public static int AnalyzeOneLine(string line)
		{
			int count = 0;
			if (!String.IsNullOrWhiteSpace(line) && line.Length > 4)
			{
				int i = 0;
				//bool patternStarted = false;
				while (i < line.Length - 4)
				{
					//string ch = line[i].ToString();
					if (line[i].ToString() == ">")
					{
						if (line[i + 1].ToString() == ">" && line[i + 2].ToString() == "-" && line[i + 3].ToString() == "-" && line[i + 4].ToString() == ">")
						{
							count++;
							i++;
						}
					}
					if (line[i].ToString() == "<")
					{
						if (line[i + 1].ToString() == "-" && line[i + 2].ToString() == "-" && line[i + 3].ToString() == "<" && line[i + 4].ToString() == "<")
						{
							count++;
							i++;
						}
					}
					i++;
				}
			}
			return count;
		}
	}
}
