using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace System.Text.Tests
{
    [TestClass()]
    public class LastIndexOfAnyTests
    {
        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim), TestStrings.ToIndexOfChars1.LastIndexOfAny(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim), TestStrings.ToIndexOfChars2.LastIndexOfAny(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 22), TestStrings.ToIndexOfChars2.LastIndexOfAny(TestStrings.SymbolsToTrim, 22));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 22, 7), TestStrings.ToIndexOfChars2.LastIndexOfAny(TestStrings.SymbolsToTrim, 22, 7));
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim), TestStrings.LeadingAndTrailingWhiteSpaces.LastIndexOfAny(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 23), TestStrings.ToIndexOfChars1.LastIndexOfAny(TestStrings.SymbolsToTrim, 23));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 22, 4), TestStrings.ToIndexOfChars2.LastIndexOfAny(TestStrings.SymbolsToTrim, 22, 4));
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb = new StringBuilder();
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim), -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullAnyOf()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOfAny(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullAnyOfIndex()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOfAny(null, 22);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullAnyOfIndexCount()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOfAny(null, 22, 7);
        }

        [TestMethod]
        public void TestIndexFirstCharacter()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 0), TestStrings.ToIndexOfChars1.LastIndexOfAny(TestStrings.SymbolsToTrim, 0));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 0), TestStrings.ToIndexOfChars2.LastIndexOfAny(TestStrings.SymbolsToTrim, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacter()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, sb.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacterWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, sb.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZeroWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, -1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, sb.Length + 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximumWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, sb.Length + 1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 0, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountEqualsZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 0, sb.Length + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexPlusCountGreaterThanLength()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOfAny(TestStrings.SymbolsToTrim, 15, 20);
        }
    }
}
