using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace System.Text.Tests
{
    [TestClass()]
    public class IndexOfCharTests
    {
        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol), TestStrings.ToIndexOfChars1.IndexOf(symbol));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol), TestStrings.ToIndexOfChars2.IndexOf(symbol));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol, 3), TestStrings.ToIndexOfChars2.IndexOf(symbol, 3));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol, 3, 7), TestStrings.ToIndexOfChars2.IndexOf(symbol, 3, 7));
            }
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol), TestStrings.LeadingAndTrailingWhiteSpaces.IndexOf(symbol));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol, 23), TestStrings.ToIndexOfChars1.IndexOf(symbol, 23));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol, 3, 4), TestStrings.ToIndexOfChars2.IndexOf(symbol, 3, 4));
            }
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol), -1);
            }
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol, 3), -1);
            }
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol, 3, 7), -1);
            }
        }

        [TestMethod]
        public void TestIndexLastCharacter()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol, sb.Length - 1), TestStrings.ToIndexOfChars1.IndexOf(symbol, sb.Length - 1));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.IndexOf(symbol, sb.Length - 1), TestStrings.ToIndexOfChars2.IndexOf(symbol, sb.Length - 1));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacter1()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], sb.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacter2()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], sb.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZeroWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], -1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], sb.Length + 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximumWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], sb.Length + 1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], 0, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountEqualsZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], 0, sb.Length + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexPlusCountGreaterThanLength()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOf(TestStrings.SymbolsToTrim[0], 5, 20);
        }
    }
}
