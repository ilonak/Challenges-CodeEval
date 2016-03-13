using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MaxStringBeauty
{
	public class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				ProcessFile(args[0], Console.Write);
				//Console.ReadLine();
			}
		}

		public static void ProcessFile(string path, Action<string> Write)
		{
			try
			{
				StreamReader sr = new StreamReader(path);
				string line = "";
				while ((line = sr.ReadLine()) != null)
				{
					int linesTotal = CalculateLineBtValue(GetDictOfUniqueCharInLine(line));
					Write(linesTotal.ToString());
					Write(Environment.NewLine);
				}
				sr.Close();
			}
			catch (Exception e)
			{
				Write("Cannot process file." + e.Message + Environment.NewLine);
			}
		}

		public static Dictionary<string, int> GetDictOfUniqueCharInLine(string line)
		{
			Dictionary<string, int> foundUnique = new Dictionary<string, int>();
			foreach (char c in line)
			{
				if (Char.IsLetter(c))
				{
					string s = (c.ToString()).ToLower();

					if (!foundUnique.ContainsKey(s))
					{
						foundUnique.Add(s, 1);
					}
					else
					{
						int count;
						foundUnique.TryGetValue(s, out count);
						foundUnique.Remove(s);
						foundUnique.Add(s, count + 1);
					}
				}
			}
			return foundUnique;
		}

		public static int CalculateLineBtValue(Dictionary<string, int> foundUnique)
		{
			int beautyValue = 26;
			int totalBeautyValue = 0;
			var valuesColl = foundUnique.Values.OrderByDescending(x => x);
			foreach (int n in valuesColl)
			{
				int charBeauty = n * beautyValue;
				beautyValue--;
				totalBeautyValue = totalBeautyValue + charBeauty;
			}
			return totalBeautyValue;
		}
	}
}
	