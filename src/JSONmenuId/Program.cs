using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JSONmenuId
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length > 0 && File.Exists(args[0]))
				ProcessFile(args[0], Console.Write);
			Console.ReadLine();
		}

		public static void ProcessFile(string path, Action<string> Write)
		{
			try
			{
				StreamReader sr = new StreamReader(path);
				string line = "";
				while ((line = sr.ReadLine()) != null)
				{
					if (!string.IsNullOrWhiteSpace(line))
					{
						int totalIds = ParseOneLine(line);
						Write(totalIds.ToString());
						Write(Environment.NewLine);
					}
				}
				sr.Close();
			}
			catch (Exception ex)
			{
				Write("The file could not be read." + ex.ToString() + Environment.NewLine);
			}
		}

		public static int ParseOneLine(string line)
		{
			char[] delimitersItems = { '[', ']' };
			char[] delimitersOneItem = { '{', '}' };

			int indexItems = line.IndexOf("items");
			string itemsSubstring = line.Substring(indexItems);

			string[] arrayItemsAll = itemsSubstring.Split(delimitersItems);
			int totalItemIdValue = 0;

			foreach (string items in arrayItemsAll)
			{
				string[] arrayItem = items.Split(delimitersOneItem);


				foreach (string item in arrayItem)
				{
					if (item.Contains("label"))
					{
						int indexId = item.IndexOf("id");
						int IdValue;
						int indexStartOfResult = item.IndexOf("id\": ") + 4;
						int lengthOfResult = item.IndexOf(",") - (item.IndexOf("id\": ") + 4);
						bool parsed = Int32.TryParse(item.Substring(indexStartOfResult, lengthOfResult), out IdValue);
						totalItemIdValue = totalItemIdValue + IdValue;
					}
				}
			}
			return totalItemIdValue;
		}

	}
}

//input example {"menu": {"header": "menu", "items": [{"id": 27}, {"id": 0, "label": "Label 0"}, null, {"id": 93}, {"id": 85}, {"id": 54}, null, {"id": 46, "label": "Label 46"}]}}

//{"menu": {"header": "menu", "items": [{"id": 81}]}}

//{"menu": {"header": "menu", "items": [{"id": 70, "label": "Label 70"}, {"id": 85, "label": "Label 85"}, {"id": 93, "label": "Label 93"}, {"id": 2}]}}