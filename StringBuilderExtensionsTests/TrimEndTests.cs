using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace System.Text.Tests
{
    [TestClass()]
    public class TrimEndTests
    {
        [TestMethod()]
        public void TestContainingWhiteSpaces()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).TrimEnd();
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.TrimEnd());
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).TrimEnd();
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.TrimEnd());
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).TrimEnd();
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.TrimEnd());
        }

        [TestMethod()]
        public void TestContainingWhiteSpacesNullTrimChars()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).TrimEnd(null);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.TrimEnd(null));
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).TrimEnd(null);
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.TrimEnd(null));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).TrimEnd(null);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.TrimEnd(null));
        }

        [TestMethod()]
        public void TestContainingWhiteSpacesEmptyTrimChars()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).TrimEnd(new char[] { });
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.TrimEnd(new char[] { }));
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).TrimEnd(new char[] { });
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.TrimEnd(new char[] { }));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).TrimEnd(new char[] { });
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.TrimEnd(new char[] { }));
        }

        [TestMethod]
        public void TestNotContainingWhiteSpaces()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.WhiteSpacesTrimmed).TrimEnd();
            Assert.AreEqual(sb.ToString(), TestStrings.WhiteSpacesTrimmed);
        }

        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingSymbols).TrimEnd(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingSymbols.TrimEnd(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.TrailingSymbols).TrimEnd(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingSymbols.TrimEnd(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingSymbols).TrimEnd(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingSymbols.TrimEnd(TestStrings.SymbolsToTrim));
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.SymbolsTrimmed).TrimEnd(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.SymbolsTrimmed);
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb;
            sb = new StringBuilder(string.Empty).TrimEnd();
            Assert.AreEqual(sb.ToString(), string.Empty);
        }

        [TestMethod]
        public void TrimWhiteSpaces()
        {
            StringBuilder sb = new StringBuilder(TestStrings.WhiteSpaces).TrimEnd();
            Assert.AreEqual(sb.ToString(), string.Empty);
        }
    }
}
