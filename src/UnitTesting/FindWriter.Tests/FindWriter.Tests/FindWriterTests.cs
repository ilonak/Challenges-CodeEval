using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindWriter.Tests
{
	[TestClass]
	public class FindWriterTests
	{
		[TestMethod]
		public void ProcessFile_NoFile_Expected_Error()
		{
			string actual = string.Empty;
			string expected = "The file could not be processed." + Environment.NewLine;
			Program.ProcessFile("not exist", (s) => { actual += s; });
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PrintWriter_empty_line_Expected_empty()
		{
			string actual = Environment.NewLine;
			string expected = Environment.NewLine;
			Program.PrintWriter(actual,null);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void PrintWriter_test_line_Expected_ABC()
		{
			string actual = string.Empty;
			string input = "CBA|3 2 1";
			string expected = "ABC" + Environment.NewLine;
			Program.PrintWriter(input, (s) => {
				actual += s; 
			});
			Assert.AreEqual(expected, actual);
		}


//				[TestMethod]
//		public void PrintReversedWords_NotExistingFile_ExpectedErrorMessage()
//		{
//			string actual = string.Empty;
//			string expected = "The file could not be read." + Environment.NewLine;
//			Program.PrintReversedWords("not exist", (s) => { actual += s; });
//			Assert.AreEqual(expected, actual);
//		}

//		[TestMethod]
//		[DeploymentItem("input.txt")]
//		public void PrintReversedWords_SampleFile_ExpectedNoErrors()
//		{
//			string actual = string.Empty;
//			string expected = "World Hello"+ Environment.NewLine + "CodeEval Hello" + Environment.NewLine;
//			Program.PrintReversedWords("input.txt", (s) => { actual += s; });
//			Assert.AreEqual(expected, actual);
//		}
//	}
//}


	}
}
