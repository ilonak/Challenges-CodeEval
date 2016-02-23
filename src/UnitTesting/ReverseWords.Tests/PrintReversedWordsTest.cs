using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseWords.Tests
{
	[TestClass]
	public class PrintReversedWordsTest
	{
		private TestContext testContextInstance;

		public TestContext TestContext
		{
			get { return testContextInstance; }
			set { testContextInstance = value; }
		}

		[TestMethod]
		public void PrintReversedWords_NotExistingFile_ExpectedErrorMessage()
		{
			string actual = string.Empty;
			string expected = "The file could not be read." + Environment.NewLine;
			Program.PrintReversedWords("not exist", (s) => { actual += s; });
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		[DeploymentItem("input.txt")]
		public void PrintReversedWords_SampleFile_ExpectedNoErrors()
		{
			string actual = string.Empty;
			string expected = "World Hello"+ Environment.NewLine + "CodeEval Hello" + Environment.NewLine;
			Program.PrintReversedWords("input.txt", (s) => { actual += s; });
			Assert.AreEqual(expected, actual);
		}
	}
}
