using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseWords.Tests
{
	[TestClass]
	public class PrintReversedWordsTest
	{

		[TestMethod]
		public void PrintReversedWords_NotExistingFile_ExpectedNothing()
		{
			Program.PrintReversedWords("not exist");
		//	Assert.AreEqual(expected, actual, "Wrong sum returned");
		}


		[TestMethod]
		public void TestMethod1()
		{
		}
	}
}
