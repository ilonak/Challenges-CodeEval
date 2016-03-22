using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RoadTrip
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
					if (!String.IsNullOrWhiteSpace(line))
					{
						//List<city> listCities = new List<city>();
						PrintDistancies(CalculateRoad(line), Console.Write);
					}
				}

			}
			catch (Exception e)
			{
				Write("The file could not be processed." + Environment.NewLine);
			}
		}

		public struct city
		{
			public string cityName { get; set; }
			public int cityDistance { get; set; }
		}

		public static List<city> CalculateRoad(string line)
		{
			char[] delimitersCities = {';'};
			char[] delimitersOneCity = {','};

			string[] oneCity = line.Split(delimitersCities, StringSplitOptions.RemoveEmptyEntries);

			List<city> listCities = new List<city>();

			foreach (string c in oneCity)
			{
				var cd = new city();
				string[] oneCityString = c.Split(delimitersOneCity);
				cd.cityName = oneCityString[0];
				int distance = 0;
				Int32.TryParse(oneCityString[1], out distance);
				cd.cityDistance = distance;

				listCities.Add(cd);
			}

			List<city> listSorted = listCities.OrderBy(x => x.cityDistance).ToList();
			return listSorted;
		}

		//public static List<city> SortCities(List<city> listUnsorted)
		//{
		//	//List<city> listSortedCities = listUnsorted.OrderBy(x => x.cityDistance).T;

		//	//for (int i = 1; i < (listUnsorted.Count); i++)
		//	//{
		//	//	int min = 0;
		//	//	for (int j = 0; j < (listUnsorted.Count - 1); j++)
		//	//	{
		//	//		if (listUnsorted[j].cityDistance	> listUnsorted[i].cityDistance)
		//	//		{
		//	//			min = listUnsorted[i].cityDistance;
		//	//			listUnsorted[i].cityDistance = listUnsorted[j].cityDistance;
		//	//			listUnsorted[j].cityDistance = min;
		//	//		}
		//	//	}
		//	//}

		//	return listUnsorted.OrderBy(x => x.cityDistance).ToList();
		//}

		public static void PrintDistancies(List<city> listSorted, Action<string> Write)
		{
			int distanceTwoCities = 0;
			int previousCityDist = 0;

			for (int i = 0; i <= listSorted.Count - 1; i++)
			{

				if (i > 0)
				{
					previousCityDist = listSorted[i - 1].cityDistance;
				} 
				distanceTwoCities = (listSorted[i].cityDistance) - previousCityDist;

				Write(distanceTwoCities.ToString());
				if (i != (listSorted.Count-1))
				{
					Write(",");
				}
			}
			Write(Environment.NewLine);
		}

	}
}
