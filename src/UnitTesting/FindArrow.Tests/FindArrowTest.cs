using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindArrow.Tests
{
	[TestClass]
	public class FindArrowTest
	{
		private TestContext testContextInstance;

		public TestContext TestContext
		{
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}

		[TestMethod]
		public void AnalyzeOneLine_EmptyLine_ExpectedZero()
		{
			var actual = Program.AnalyzeOneLine(string.Empty);
			//Program.PrintReversedWords("not exist", (s) => { actual += s; });
			Assert.AreEqual(0, actual);
		}

		[TestMethod]
		public void AnalyzeOneLine_OneArrow_ExpectedOne()
		{
			var actual = Program.AnalyzeOneLine("------->>-->---------------");
			//Program.PrintReversedWords("not exist", (s) => { actual += s; });
			Assert.AreEqual(1, actual);
		}

		[TestMethod]
		public void AnalyzeOneLine_TwoArrows_ExpectedTwo()
		{
			var actual = Program.AnalyzeOneLine("-<<-<--<<--->>-->-------------->");
			//Program.PrintReversedWords("not exist", (s) => { actual += s; });
			Assert.AreEqual(2, actual);
		}

	//	[TestMethod]
	//	public void PrintReversedWords_NotExistingFile_ExpectedErrorMessage()
	//	{
	//		string actual = string.Empty;
	//		string expected = "The file could not be read." + Environment.NewLine;
	//		//Program.PrintReversedWords("not exist", (s) => { actual += s; });
	//		Assert.AreEqual(expected, actual);
	//	}
	//
	//	[TestMethod]
	//	[DeploymentItem("input.txt")]
	//	public void PrintReversedWords_SampleFile_ExpectedNoErrors()
	//	{
	//		string actual = string.Empty;
	//		string expected = "World Hello"+ Environment.NewLine + "CodeEval Hello" + Environment.NewLine;
	//		//Program.PrintReversedWords("input.txt", (s) => { actual += s; });
	//		Assert.AreEqual(expected, actual);
	//	}
	}
}
