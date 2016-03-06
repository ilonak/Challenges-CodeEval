using System;
using System.IO;

namespace StringToLower
{
	public class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				FileInfo file = new FileInfo(args[0]);
				long fileSize = file.Length;
				Console.WriteLine(fileSize.ToString());
				//Console.ReadLine();
			}
		}
	}
}