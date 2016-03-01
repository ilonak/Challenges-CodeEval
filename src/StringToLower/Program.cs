using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringToLower
{
	public class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				ReadFile(args[0], Console.Write);
				Console.ReadLine();
			}
		}

		private static void ReadFile(string path, Action<string> Write)
		{
			try
			{
				StreamReader sr = new StreamReader(path);
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					ConvertOneLine(line, Console.Write);
				}
				sr.Close();
			}
			catch (Exception ex)
			{
				Write("File could not be read." + ex.ToString() + Environment.NewLine);
			}
		}

		private static void ConvertOneLine(string line, Action<string> Write)
		{
			//if (!String.IsNullOrWhiteSpace(line))
			//{
				foreach (char c in line)
				{
					if (Char.IsUpper(c))
					{
						Write((Char.ToLower(c)).ToString());
					}
					else 
					{
						Write(c.ToString());
					}
				}
				Write(Environment.NewLine);
			//}
		}
	}
}

//static void Main(string[] args)
//		{
//			if (args.Length > 0 && File.Exists(args[0]))
//				AnalyzeFileForArrows(args[0], Console.Write);
//		}

//		public static void AnalyzeFileForArrows(string path, Action<string> Write)
//		{
//			try
//			{
//				string line;
//				StreamReader reader = new StreamReader(path);
//				while ((line = reader.ReadLine()) != null)
//				{
//					int count = AnalyzeOneLine(line);
//					Write(count.ToString());
//					Write(Environment.NewLine);
//				}
//				reader.Close();
//			}
//			catch (Exception ex)
//			{
//				Write("The file could not be read." + ex.ToString() + Environment.NewLine);
//			}
//		}

//		public static int AnalyzeOneLine(string line)
//		{
//			int count = 0;
//			if (!String.IsNullOrWhiteSpace(line) && line.Length > 4)
//			{
//				int i = 0;
//				while (i < line.Length - 4)
//				{
//					if (line[i + 2] == '-')
//					{
//						if (line[i] == '>' && line[i + 1] == '>' && line[i + 3] == '-' && line[i + 4] == '>')
//						{
//							count++;
//							i += 3;
//						}
//						else if (line[i] == '<' && line[i + 1] == '-' && line[i + 3] == '<' && line[i + 4] == '<')
//						{
//							count++;
//							i += 3;
//						}
//					}
//					i++;
//				}
//			}
//			return count;
//		}
//	}
//}
