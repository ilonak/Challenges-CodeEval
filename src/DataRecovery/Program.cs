using System;
using System.Collections.Generic;
using System.IO;


namespace DataRecovery
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
						char[] delimiter1 = { ';' };
						char[] delimiter2 = { ' ' };
						List<string> listWords = new List<string>();

						string[] separatedLine = line.Split(delimiter1, StringSplitOptions.RemoveEmptyEntries);

						string[] separatedWords = separatedLine[0].Split(delimiter2, StringSplitOptions.RemoveEmptyEntries);
						string[] separatedNumbers = separatedLine[1].Split(delimiter2, StringSplitOptions.RemoveEmptyEntries);

						for (int i = 0; i < (separatedWords.Length); i++)
						{
							listWords.Add(String.Empty);
						}

						for (int i = 0; i < (separatedNumbers.Length); i++)
						{
							listWords.RemoveAt(Int32.Parse(separatedNumbers[i]) - 1);
							listWords.Insert((Int32.Parse(separatedNumbers[i])-1), separatedWords[i]);
						}


						for (int i = 0; i < listWords.Count; i++ )
						{
							if (String.IsNullOrEmpty(listWords[i]))
							{
								listWords.RemoveAt(i);
								listWords.Insert(i, separatedWords[separatedWords.Length - 1]);
							}
						}

						bool printed = false;
						foreach (string s in listWords)
						{
							if (printed)
							{
								Write(" ");
							}
							Write(s);
							printed = true;
						}

						Write(Environment.NewLine);
					}
				}
			}
			catch (Exception e)
			{
				Console.Write(e);
			}
		}
	}
}


				//while ((line = sr.ReadLine()) != null)
				//{
				//	if (!String.IsNullOrWhiteSpace(line))
				//	{
				//		char[] delimiter1 = { ';' };
				//		char[] delimiter2 = { ' ' };
				//		Dictionary<int, string> Sentences = new Dictionary<int, string>();
				//		string[] separatedLine = line.Split(delimiter1, StringSplitOptions.RemoveEmptyEntries);

				//		string[] separatedSentence = separatedLine[0].Split(delimiter2, StringSplitOptions.RemoveEmptyEntries);
				//		string[] separatedKeys = separatedLine[1].Split(delimiter2, StringSplitOptions.RemoveEmptyEntries);

				//		for (int i = 0; i < separatedSentence.Length; i++)
				//		{
				//			Sentences.Add(Int32.Parse(separatedKeys[i]), separatedSentence[i]);
				//		}

				//		Dictionary<int, string> sortedDictionary = Sentences.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

				//		foreach (KeyValuePair<int, string> item in sortedDictionary)
				//		{
				//			Write(item.Value + " ");
				//		}

				//	}
				//}