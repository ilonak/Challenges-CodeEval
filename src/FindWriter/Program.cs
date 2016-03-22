using System;
using System.Collections.Generic;
using System.IO;

namespace FindWriter
{
	public class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				ProcessFile(args[0], Console.Write);
				Console.ReadLine();
			}
		}

		public static void ProcessFile(string file, Action<string> Write)
		{
			try
			{
				string line = "";
				StreamReader sr = new StreamReader(file);
				while ((line = sr.ReadLine()) != null)
				{
					PrintWriter(line, Console.Write);
				}
			}
			catch (Exception e) 
			{ 
				Write("The file could not be processed." + Environment.NewLine);
			}
		}

		public static void PrintWriter(string line, Action<string> Write)
		{
			if (!String.IsNullOrWhiteSpace(line))
			{
				string[] delimiters = { " " };
				int indexPipe = line.IndexOf("|");
				string stringCodedChars = line.Substring(0, indexPipe);

				string stringAfterPipe = line.Substring(indexPipe + 1);
				string[] arrayKeys = stringAfterPipe.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

				foreach (string i in arrayKeys)
				{
					Write((stringCodedChars[Int32.Parse(i) - 1]).ToString());
				}
				Write(Environment.NewLine);
			}
		}
	}
}
