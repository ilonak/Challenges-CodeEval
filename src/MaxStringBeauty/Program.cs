using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxStringBeauty
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
				GetDictOfUniqueChar(args[0], Console.Write);
		}
		
		public static void GetDictOfUniqueChar(string path, Action<string> Write)
		{
			try
			{
				string line;
				StreamReader sr = new StreamReader(path);
				while ((line = sr.ReadLine()) != null)
				{
					String found = string.Empty;
					Dictionary<string, int> foundUnique = new Dictionary<string, int>();
					foreach (char c in line)
					{
						string s = c.ToString();

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
			}
			catch (Exception e)
			{
				Write("Cannot process file." + e.Message + Environment.NewLine);
			}
		}
	}
}

		//public static string ReadOneLine(string path, Action<string> Write)
		//{
		//					string line;
		//	try
		//	{
		//		StreamReader sr = new StreamReader(path);
		//		while ((line = sr.ReadLine()) != null)
		//		{
		//			GetDictOfUniqueChar(line);
		//		}

		//	}
		//	catch(Exception e)
		//	{
		//		Write("Cannot process file." + e.Message + Environment.NewLine);
		//	}
		//					return line;
		//}

//		public int DetermineMaxValue(Dictionary foundUnique)
//{
//int maxCharCount = 0;
//foreach (var foundUnique.Key in foundUnique)
//{ 
//if (foundUnique.Value > max)
//{
//maxCharCount = foundUnique.Value;
//}

//return foundUnique(key);
//}
//	}
//}



//public int DetermineMaxValue(Dictionary foundUnique)
//{
//int maxCharCount = 0;
//foreach (var foundUnique.Key in foundUnique)
//{ 
//if (foundUnique.Value > max)
//{
//maxCharCount = foundUnique.Value;
//}

//return foundUnique(key);
//}

//remove.foundUnique(s);
//Int maxValue = DetermineMaxValue();
//Int maxBeauty = 26;

//While (not end of dictionary)
//{
//Public int AssignMaxBeauty()
//{
//Int maxCharBeauty = maxValue * maxBeauty;
//maxBeauty --;
//}
//}
//Int maxStringBeauty = maxCharBeuty + maxCharBeauty;
//}
		
