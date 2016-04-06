using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BigDigits
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

		private static void ProcessFile(string p, Action<string> Write)
		{
			try
			{
				StreamReader sr = new StreamReader(p);
				string line2;

				string[] line01 = new string[] {
				"-**--",
				"--*--",
				"***--",
				"***--",
				"-*---",
				"****-",
				"-**--",
				"****-",
				"-**--",
				"-**--"
			};

				string[] line02 = new string[] {
					("*--*-"),
					("-**--"),
					("---*-"),
					("---*-"),
					("*--*-"),
					("*----"),
					("*----"),
					("---*-"),
					("*--*-"),
					("*--*-")
				};
				string[] line03 = new string[] {
									("*--*-"),
									("--*--"),
									("-**--"),
									("-**--"),
									("****-"),
									("***--"),
									("***--"),
									("--*--"),
									("-**--"),
									("-***-")
		};
				string[] line04 = new string[] {

					("*--*-"),
					("--*--"),
					("*----"),
					("---*-"),
					("---*-"),
					("---*-"),
					("*--*-"),
					("-*---"),
					("*--*-"),
					("---*-")
			
			};

				string[] line05 = new string[] { 
											("-**--"),
											("-***-"),
											("****-"),
											("***--"),
											("---*-"),
											("***--"),
											("-**--"),
											("-*---"),
											("-**--"),
											("-**--")
				};
				while ((line2 = sr.ReadLine()) != null)
				{

					line2.Any((c) =>
					{
						if (char.IsDigit(c))
						{
							int number = Int32.Parse(c.ToString());
							Write(line01[number]);
						}
						return false;
					});
					Write(Environment.NewLine);
					line2.Any((c) =>
					{
						if (char.IsDigit(c))
						{
							int number = Int32.Parse(c.ToString());
							Write(line02[number]);
						}
						return false;
					});
					Write(Environment.NewLine);
					line2.Any((c) =>
					{
						if (char.IsDigit(c))
						{
							int number = Int32.Parse(c.ToString());
							Write(line03[number]);
						}
						return false;
					});
					Write(Environment.NewLine);
					line2.Any((c) =>
					{
						if (char.IsDigit(c))
						{
							int number = Int32.Parse(c.ToString());
							Write(line04[number]);
						}
						return false;
					});
					Write(Environment.NewLine);
					line2.Any((c) =>
					{
						if (char.IsDigit(c))
						{
							int number = Int32.Parse(c.ToString());
							Write(line05[number]);
						}
						return false;
					});
					Write(Environment.NewLine);
					line2.Any((c) =>
					{
						if (char.IsDigit(c))
						{
							int number = Int32.Parse(c.ToString());
							Write("-----");
						}
						return false;
					});
					Write(Environment.NewLine);
				}
			}
			catch (Exception e)
			{
			}
		}
	}
}

//try
//{
//	StreamReader sr = new StreamReader(p);
//	string line;
//	while ((line = sr.ReadLine()) != null)
//	{
//		foreach (char c in line)
//		{
//			int number;
//			bool isDigit = Int32.TryParse(c.ToString(), out number);
//			if (isDigit)
//			{
//				switch (number)
//				{
//					case 0:
//						Write("-**--");
//						break;
//					case 1:
//						Write("--*--");
//						break;
//					case 2:
//						Write("***--");
//						break;
//					case 3:
//						Write("***--");
//						break;
//					case 4:
//						Write("-*---");
//						break;
//					case 5:
//						Write("****-");
//						break;
//					case 6:
//						Write("-**--");
//						break;
//					case 7:
//						Write("****-");
//						break;
//					case 8:
//						Write("-**--");
//						break;
//					case 9:
//						Write("-**--");
//						break;
//				}
//			}
//		}
//		Write(Environment.NewLine);
//		foreach (char c in line)
//		{
//			int number;
//			bool isDigit = Int32.TryParse(c.ToString(), out number);
//			if (isDigit)
//			{
//				switch (number)
//				{
//					case 0:
//						Write("*--*-");
//						break;
//					case 1:
//						Write("-**--");
//						break;
//					case 2:
//						Write("---*-");
//						break;
//					case 3:
//						Write("---*-");
//						break;
//					case 4:
//						Write("*--*-");
//						break;
//					case 5:
//						Write("*----");
//						break;
//					case 6:
//						Write("*----");
//						break;
//					case 7:
//						Write("--*--");
//						break;
//					case 8:
//						Write("*--*-");
//						break;
//					case 9:
//						Write("*--*-");
//						break;
//				}
//			}
//		}
//		Write(Environment.NewLine);
//		foreach (char c in line)
//		{
//			int number;
//			bool isDigit = Int32.TryParse(c.ToString(), out number);
//			if (isDigit)
//			{
//				switch (number)
//				{
//					case 0:
//						Write("*--*-");
//						break;
//					case 1:
//						Write("--*--");
//						break;
//					case 2:
//						Write("-**--");
//						break;
//					case 3:
//						Write("-**--");
//						break;
//					case 4:
//						Write("****-");
//						break;
//					case 5:
//						Write("***--");
//						break;
//					case 6:
//						Write("***--");
//						break;
//					case 7:
//						Write("--*--");
//						break;
//					case 8:
//						Write("-**--");
//						break;
//					case 9:
//						Write("-***-");
//						break;
//				}
//			}
//		}
//		Write(Environment.NewLine);
//		foreach (char c in line)
//		{
//			int number;
//			bool isDigit = Int32.TryParse(c.ToString(), out number);
//			if (isDigit)
//			{
//				switch (number)
//				{
//					case 0:
//						Write("*--*-");
//						break;
//					case 1:
//						Write("--*--");
//						break;
//					case 2:
//						Write("*----");
//						break;
//					case 3:
//						Write("---*-");
//						break;
//					case 4:
//						Write("---*-");
//						break;
//					case 5:
//						Write("---*-");
//						break;
//					case 6:
//						Write("*--*-");
//						break;
//					case 7:
//						Write("-*---");
//						break;
//					case 8:
//						Write("*--*-");
//						break;
//					case 9:
//						Write("---*-");
//						break;
//				}
//			}
//		}
//		Write(Environment.NewLine);
//		foreach (char c in line)
//		{
//			int number;
//			bool isDigit = Int32.TryParse(c.ToString(), out number);
//			if (isDigit)
//			{
//				switch (number)
//				{
//					case 0:
//						Write("-**--");
//						break;
//					case 1:
//						Write("-***-");
//						break;
//					case 2:
//						Write("****-");
//						break;
//					case 3:
//						Write("***--");
//						break;
//					case 4:
//						Write("---*-");
//						break;
//					case 5:
//						Write("***--");
//						break;
//					case 6:
//						Write("-**---");
//						break;
//					case 7:
//						Write("-*---");
//						break;
//					case 8:
//						Write("-**--");
//						break;
//					case 9:
//						Write("-**--");
//						break;
//				}
//			}
//		}
//		Write(Environment.NewLine);
//		foreach (char c in line)
//		{
//			int number;
//			bool isDigit = Int32.TryParse(c.ToString(), out number);
//			if (isDigit)
//			{
//				Write("-----");
//			}
//		}
//		Write(Environment.NewLine);
//	}
//}

