using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexToDecimal
{
	class Program
	{
		enum HexAlphas { a = 11, b, c, d, e, f };

		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
			{
				ProcessFile(args[0], Console.Write);
			}
			Console.ReadLine();
		}

		public static void ProcessFile(string path, Action<string> Write)
		{
			int[] array = new int[256];
			array['0'] = 0;
			array['1'] = 1;
			array['2'] = 2;
			array['3'] = 3;
			array['4'] = 4;
			array['5'] = 5;
			array['6'] = 6;
			array['7'] = 7;
			array['A'] = 10;
			try
			{
				StreamReader sr = new StreamReader(path);
				string line;
				while ((line = sr.ReadLine()) != null && !String.IsNullOrWhiteSpace(line))
				{
					int converted = 0;
					for (int i = line.Length - 1; i >= 0; i--)
					{
						int d = array[line[i]];
						char hexDigit = line[i];
						if (hexDigit <= '9')
						{
							int number = Convert.ToInt32(hexDigit);
							//converted + 
						}
						else if (hexDigit < 'G')
						{
							int number = 10 + hexDigit - 'A';  
						}
						else if (hexDigit < 'g')
						{
							int number = 10 + hexDigit - 'a';
						}
						//if (Enum.IsDefined(typeof(HexAlphas), name))
						//{
						//	int alpha = HexAlphas.
						//
						//}


					}

				}

			}
			catch (Exception e)
			{
				Write("File cannot be processed" + e);
			}
		}
	}
}
