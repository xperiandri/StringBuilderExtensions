using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace System.Text.Tests
{
    [TestClass()]
    public class IndexOfAnyTests
    {
        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim), TestStrings.ToIndexOfChars1.IndexOfAny(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim), TestStrings.ToIndexOfChars2.IndexOfAny(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim, 3), TestStrings.ToIndexOfChars2.IndexOfAny(TestStrings.SymbolsToTrim, 3));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim, 3, 7), TestStrings.ToIndexOfChars2.IndexOfAny(TestStrings.SymbolsToTrim, 3, 7));
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.LeadingAndTrailingWhiteSpaces);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim), TestStrings.LeadingAndTrailingWhiteSpaces.IndexOfAny(TestStrings.SymbolsToTrim));
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim, 23), TestStrings.ToIndexOfChars1.IndexOfAny(TestStrings.SymbolsToTrim, 23));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim, 3, 4), TestStrings.ToIndexOfChars2.IndexOfAny(TestStrings.SymbolsToTrim, 3, 4));
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb = new StringBuilder();
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim), -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullAnyOf()
        {
            StringBuilder sb = new StringBuilder();
            sb.IndexOfAny(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullAnyOfIndex()
        {
            StringBuilder sb = new StringBuilder();
            sb.IndexOfAny(null, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullAnyOfIndexCount()
        {
            StringBuilder sb = new StringBuilder();
            sb.IndexOfAny(null, 3, 7);
        }

        [TestMethod]
        public void TestIndexLastCharacter()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim, sb.Length - 1), TestStrings.ToIndexOfChars1.IndexOfAny(TestStrings.SymbolsToTrim, sb.Length - 1));
            sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            Assert.AreEqual(sb.IndexOfAny(TestStrings.SymbolsToTrim, sb.Length - 1), TestStrings.ToIndexOfChars2.IndexOfAny(TestStrings.SymbolsToTrim, sb.Length - 1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacter()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, sb.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacterWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars2);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, sb.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZeroWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, -1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, sb.Length + 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximumWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, sb.Length + 1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, 0, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountEqualsZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, 0, sb.Length + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexPlusCountGreaterThanLength()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.IndexOfAny(TestStrings.SymbolsToTrim, 5, 20);            
        }
    }
}
