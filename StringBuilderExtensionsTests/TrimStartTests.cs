using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace System.Text.Tests
{
    [TestClass()]
    public class TrimStartTests
    {
        [TestMethod()]
        public void TestContainingWhiteSpaces()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).TrimStart();
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.TrimStart());
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).TrimStart();
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.TrimStart());
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).TrimStart();
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.TrimStart());
        }

        [TestMethod()]
        public void TestContainingWhiteSpacesNullTrimChars()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).TrimStart(null);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.TrimStart(null));
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).TrimStart(null);
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.TrimStart(null));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).TrimStart(null);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.TrimStart(null));
        }

        [TestMethod()]
        public void TestContainingWhiteSpacesEmptyTrimChars()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).TrimStart(new char[] { });
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.TrimStart(new char[] { }));
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).TrimStart(new char[] { });
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.TrimStart(new char[] { }));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).TrimStart(new char[] { });
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.TrimStart(new char[] { }));
        }

        [TestMethod]
        public void TestNotContainingWhiteSpaces()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.WhiteSpacesTrimmed).TrimStart();
            Assert.AreEqual(sb.ToString(), TestStrings.WhiteSpacesTrimmed);
        }

        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingSymbols).TrimStart(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingSymbols.TrimStart(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.TrailingSymbols).TrimStart(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingSymbols.TrimStart(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingSymbols).TrimStart(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingSymbols.TrimStart(TestStrings.SymbolsToTrim));
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.SymbolsTrimmed).TrimStart(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.SymbolsTrimmed);
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb;
            sb = new StringBuilder(string.Empty).TrimStart();
            Assert.AreEqual(sb.ToString(), string.Empty);
        }

        [TestMethod]
        public void TrimWhiteSpaces()
        {
            StringBuilder sb = new StringBuilder(TestStrings.WhiteSpaces).TrimStart();
            Assert.AreEqual(sb.ToString(), string.Empty);
        }
    }
}
