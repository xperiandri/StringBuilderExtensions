using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.Text.Tests
{
    [TestClass()]
    public class TrimTests
    {
        [TestMethod()]
        public void TestContainingWhiteSpaces()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).Trim();
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.Trim());
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).Trim();
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.Trim());
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).Trim();
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.Trim());
        }

        [TestMethod()]
        public void TestContainingWhiteSpacesNullTrimChars()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).Trim(null);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.Trim(null));
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).Trim(null);
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.Trim(null));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).Trim(null);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.Trim(null));
        }

        [TestMethod()]
        public void TestContainingWhiteSpacesEmptyTrimChars()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingWhiteSpaces).Trim(new char[] {});
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingWhiteSpaces.Trim(new char[] { }));
            sb = new StringBuilder(TestStrings.TrailingWhiteSpaces).Trim(new char[] { });
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingWhiteSpaces.Trim(new char[] { }));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).Trim(new char[] { });
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces.Trim(new char[] { }));
        }

        [TestMethod]
        public void TestNotContainingWhiteSpaces()
        {
            StringBuilder sb = new StringBuilder(TestStrings.WhiteSpacesTrimmed).Trim();
            Assert.AreEqual(sb.ToString(), TestStrings.WhiteSpacesTrimmed);
        }
        
        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingSymbols).Trim(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingSymbols.Trim(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.TrailingSymbols).Trim(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.TrailingSymbols.Trim(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.LeadingAndTrailingSymbols).Trim(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingSymbols.Trim(TestStrings.SymbolsToTrim));
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb = new StringBuilder(TestStrings.SymbolsTrimmed).Trim(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.SymbolsTrimmed);
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb = new StringBuilder(string.Empty).Trim();
            Assert.AreEqual(sb.ToString(), string.Empty);
        }

        [TestMethod]
        public void TrimWhiteSpaces()
        {
            StringBuilder sb = new StringBuilder(TestStrings.WhiteSpaces).Trim();
            Assert.AreEqual(sb.ToString(), string.Empty);
        }
    }
}
