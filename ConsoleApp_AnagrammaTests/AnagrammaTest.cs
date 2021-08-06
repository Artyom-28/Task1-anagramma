using ConsoleApp_Anagramma;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp_Anagramma.Tests
{
	[TestClass()]
	public class AnagrammaTest
	{
		[TestMethod()]
		public void GetAnagramma_ab3F_dr_Fb3a_rd_returned()
		{
			string originalString = "ab3F dr ";
			string expectedString = "Fb3a rd ";

			Anagramma A = new Anagramma(originalString);
			string actual = A.GetAnagramma();

			Assert.AreEqual(expected: expectedString, actual: actual);
		}


		[TestMethod()]
		public void GetAnagramma_EmptyString()
		{
			string originalString = String.Empty;
			string expectedString = String.Empty;

			Anagramma A = new Anagramma(originalString);
			string actual = A.GetAnagramma();

			Assert.AreEqual(expected: expectedString, actual: actual);
		}


		[TestMethod]
		public void GetAnagrammaDoubleReverse()
		{
			string originalString = " d3cb2a  atte2rg  d3cb2a o9 atte2rg atte2rg    d3cb2a  d3cb2a Rot%Y";
			Anagramma A = new Anagramma(originalString);

			string actual = (new Anagramma(A.GetAnagramma())).GetAnagramma();

			Assert.AreEqual(expected: originalString, actual: actual);
		}


		[TestMethod]
		public void GetRewerseWord_abL1C_CLb1a_returned()
		{
			string wordOriginal = "abL1C";
			string expectedString = "CLb1a";
			object[] Args = new object[1] { wordOriginal };

			Anagramma A = new Anagramma("");
			Type typeOf_A = typeof(Anagramma);

			string actual = (string)typeOf_A.InvokeMember("GetRewerseWord"
														  ,BindingFlags.InvokeMethod
														  | BindingFlags.NonPublic
														  | BindingFlags.Public
														  | BindingFlags.Instance
														  ,null, A, Args);

			Assert.AreEqual(expectedString, actual);
		}
	}
}


