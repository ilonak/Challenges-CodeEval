using System;
using System.IO;

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
				while ((line = reader.ReadLine()) != null)
				{
					int count = AnalyzeOneLine(line);
					Write(count.ToString());
					Write(Environment.NewLine);
				}
				Console.ReadLine();
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
				while (i < line.Length - 4)
				{
					//string subS = line.Substring(i, 5);
					//if (subS == ">>-->" || subS == "<--<<")
					//{
					//	count++;
					//}
					//i++;


					char ch = line[i];
					if (ch == '>')
					{
						if (line[i + 1] == '>' && line[i + 2] == '-' && line[i + 3] == '-' && line[i + 4] == '>')
						{
							count++;
							i++;
						}
					}
					else if (ch == '<')
					{
						if (line[i + 1] == '-' && line[i + 2] == '-' && line[i + 3] == '<' && line[i + 4] == '<')
						{
							count++;
							i++;
						}
					}
					i++;
				}


				//	if (line[i].ToString() == ">")
				//	{
				//		if (line[i + 1].ToString() == ">" && line[i + 2].ToString() == "-" && line[i + 3].ToString() == "-" && line[i + 4].ToString() == ">")
				//		{
				//			count++;
				//			i++;
				//		}
				//	}
				//	if (line[i].ToString() == "<")
				//	{
				//		if (line[i + 1].ToString() == "-" && line[i + 2].ToString() == "-" && line[i + 3].ToString() == "<" && line[i + 4].ToString() == "<")
				//		{
				//			count++;
				//			i++;
				//		}
				//	}
				//	i++;
				//}
			}
			return count;
		}
	}
}
