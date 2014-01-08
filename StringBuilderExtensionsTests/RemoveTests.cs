using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace System.Text.Tests
{
    [TestClass()]
    public class RemoveTests
    {
        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).Remove(' ');
            Assert.AreEqual(sb.ToString(), TestStrings.WhiteSpacesRemoved);
            sb = new StringBuilder(TestStrings.LeadingAndTrailingSymbols).Remove(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.SymbolsRemoved);
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces).Remove(TestStrings.SymbolsToTrim);
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingWhiteSpaces);
            sb = new StringBuilder(TestStrings.LeadingAndTrailingSymbols).Remove(' ');
            Assert.AreEqual(sb.ToString(), TestStrings.LeadingAndTrailingSymbols);
        }

        [TestMethod]
        public void TestByStartIndex()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1 + TestStrings.Composition2).Remove(TestStrings.Composition1.Length);
            Assert.AreEqual(sb.ToString(), TestStrings.Composition1);
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb = new StringBuilder().Remove(' ');
            Assert.AreEqual(sb.ToString(), string.Empty);
        }

        [TestMethod]
        public void TestRemoveAllCharacters()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1).Remove(0);
            Assert.AreEqual(sb.ToString(), string.Empty);
        }

        [TestMethod]
        public void TestRemoveLastCharacter()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1).Remove(TestStrings.Composition1.Length - 1);
            Assert.AreEqual(sb.ToString(), TestStrings.Composition1.Substring(0, TestStrings.Composition1.Length - 1));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1).Remove(-1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.Remove(sb.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullRemoveChars()
        {
            StringBuilder sb = new StringBuilder().Remove(null);
        }
    }
}
