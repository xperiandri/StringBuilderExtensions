using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace System.Text.Tests
{
    [TestClass()]
    public class LastIndexOfCharTests
    {
        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol), TestStrings.ToIndexOfChars1.LastIndexOf(symbol));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol), TestStrings.ToIndexOfChars2.LastIndexOf(symbol));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol, 22), TestStrings.ToIndexOfChars2.LastIndexOf(symbol, 22));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol, 22, 7), TestStrings.ToIndexOfChars2.LastIndexOf(symbol, 22, 7));
            }
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol), TestStrings.LeadingAndTrailingWhiteSpaces.LastIndexOf(symbol));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol, 23), TestStrings.ToIndexOfChars1.LastIndexOf(symbol, 23));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol, 22, 4), TestStrings.ToIndexOfChars2.LastIndexOf(symbol, 22, 4));
            }
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol), -1);
            }
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol, 22), -1);
            }
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol, 22, 7), -1);
            }
        }

        [TestMethod]
        public void TestIndexFirstCharacter()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol, 0), TestStrings.ToIndexOfChars1.LastIndexOf(symbol, 0));
            }
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            foreach (char symbol in TestStrings.SymbolsToTrim)
            {
                Assert.AreEqual(sb.LastIndexOf(symbol, 0), TestStrings.ToIndexOfChars2.LastIndexOf(symbol, 0));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacter1()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], sb.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacter2()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], sb.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZeroWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], -1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], sb.Length + 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximumWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], sb.Length + 1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], 0, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountEqualsZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], 0, sb.Length + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexPlusCountGreaterThanLength()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.SymbolsToTrim[0], 15, 20);
        }
    }
}
