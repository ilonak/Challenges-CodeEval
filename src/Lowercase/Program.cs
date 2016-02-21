using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lowercase
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		static void ToLowercase(string path)
		{
			try
			{
				StreamReader sr = new StreamReader();
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					Console.WriteLine(line.ToLower());
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}


		}

	}
}
