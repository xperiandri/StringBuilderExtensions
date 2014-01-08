using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace System.Text.Tests
{
    [TestClass()]
    public class LastIndexOfStringTests
    {
        private static readonly string correctStringToSearch1 = string.Concat(TestStrings.Composition1, TestStrings.Searched, TestStrings.Composition2, TestStrings.Searched);
        private static readonly string correctStringToSearch2 = string.Concat(TestStrings.Searched, TestStrings.Composition1, TestStrings.Composition2);
        private static readonly string correctStringToSearchUpperCase1 = string.Concat(TestStrings.Composition1, TestStrings.Searched, TestStrings.Composition2, TestStrings.Searched.ToUpper());
        private static readonly string correctStringToSearchUpperCase2 = string.Concat(TestStrings.Searched.ToUpper(), TestStrings.Composition1, TestStrings.Composition2);
        private static readonly string incorrectStringToSearch = string.Concat(TestStrings.Composition1, TestStrings.Composition2);
        private static readonly string correctSmallStringToSearch = string.Concat(TestStrings.Searched.Substring(10), TestStrings.Composition1.Substring(10));
        private static readonly string incorrectSmallStringToSearch = TestStrings.Composition1;
        private static readonly int startIndexCorrectString1 = correctStringToSearch1.Length - 4;
        private static readonly int startIndexCorrectString2 = correctStringToSearch2.Length - 4;
        private static readonly int startIndexIncorrectString = incorrectStringToSearch.Length - 4;

        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(correctStringToSearch1);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched), correctStringToSearch1.LastIndexOf(TestStrings.Searched));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString1), correctStringToSearch1.LastIndexOf(TestStrings.Searched, startIndexCorrectString1));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 55), correctStringToSearch1.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 55), "Result = -1, contains a part of sting in the specified range");
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 57), correctStringToSearch1.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 57), "Result = 15, contains full string in the specified range");
            int count = startIndexCorrectString2 + 1;
            sb = new StringBuilder(correctStringToSearch2);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched), correctStringToSearch2.LastIndexOf(TestStrings.Searched));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString2), correctStringToSearch2.LastIndexOf(TestStrings.Searched, startIndexCorrectString2));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString2, count), correctStringToSearch2.LastIndexOf(TestStrings.Searched, startIndexCorrectString2, count));
        }

        [TestMethod()]
        public void TestContainingCharactersIgnoreCase()
        {
            StringBuilder sb;
            sb = new StringBuilder(correctStringToSearchUpperCase1);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, true), correctStringToSearchUpperCase1.LastIndexOf(TestStrings.Searched, StringComparison.CurrentCultureIgnoreCase));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, true), correctStringToSearchUpperCase1.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, StringComparison.CurrentCultureIgnoreCase));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 55, true), correctStringToSearchUpperCase1.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 55, StringComparison.CurrentCultureIgnoreCase));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 57, true), correctStringToSearchUpperCase1.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 57, StringComparison.CurrentCultureIgnoreCase));
            int count = startIndexCorrectString2 + 1;
            sb = new StringBuilder(correctStringToSearchUpperCase2);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, true), correctStringToSearchUpperCase2.LastIndexOf(TestStrings.Searched, StringComparison.CurrentCultureIgnoreCase));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString2, true), correctStringToSearchUpperCase2.LastIndexOf(TestStrings.Searched, startIndexCorrectString2, StringComparison.CurrentCultureIgnoreCase));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString2, count, true), correctStringToSearchUpperCase2.LastIndexOf(TestStrings.Searched, startIndexCorrectString2, count, StringComparison.CurrentCultureIgnoreCase));
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(incorrectStringToSearch);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched), incorrectStringToSearch.LastIndexOf(TestStrings.Searched));
            sb = new StringBuilder(incorrectStringToSearch);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexIncorrectString), incorrectStringToSearch.LastIndexOf(TestStrings.Searched, startIndexIncorrectString));
            sb = new StringBuilder(incorrectStringToSearch);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndexIncorrectString, 32), incorrectStringToSearch.LastIndexOf(TestStrings.Searched, startIndexIncorrectString, 32));
        }

        [TestMethod]
        public void TestNotContainingCharactersIgnoreCase()
        {
            string testStringsSearchedToUpper = TestStrings.Searched.ToUpper();

            StringBuilder sb;
            sb = new StringBuilder(incorrectStringToSearch);
            Assert.AreEqual(sb.LastIndexOf(testStringsSearchedToUpper, true), incorrectStringToSearch.LastIndexOf(testStringsSearchedToUpper, StringComparison.CurrentCultureIgnoreCase));
            sb = new StringBuilder(incorrectStringToSearch);
            Assert.AreEqual(sb.LastIndexOf(testStringsSearchedToUpper, startIndexIncorrectString, true), incorrectStringToSearch.LastIndexOf(testStringsSearchedToUpper, startIndexIncorrectString, StringComparison.CurrentCultureIgnoreCase));
            sb = new StringBuilder(incorrectStringToSearch);
            Assert.AreEqual(sb.LastIndexOf(testStringsSearchedToUpper, startIndexIncorrectString, 32, true), incorrectStringToSearch.LastIndexOf(testStringsSearchedToUpper, startIndexIncorrectString, 32, StringComparison.CurrentCultureIgnoreCase));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullValue()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOf(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullValueWithIndex()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOf(null, startIndexCorrectString1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullValueWithIndexAndCount()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOf(null, startIndexCorrectString1, 55);
        }

        [TestMethod]
        public void TestEmptyValue()
        {
            StringBuilder sb;
            sb = new StringBuilder();
            Assert.AreEqual(sb.LastIndexOf(string.Empty), string.Empty.LastIndexOf(string.Empty));
            //correctStringToSearch.LastIndexOf(string.Empty, startIndexCorrectString, 55);
            sb = new StringBuilder(correctStringToSearch1);
            Assert.AreEqual(sb.LastIndexOf(string.Empty), correctStringToSearch1.LastIndexOf(string.Empty));
            Assert.AreEqual(sb.LastIndexOf(string.Empty, startIndexCorrectString1), correctStringToSearch1.LastIndexOf(string.Empty, startIndexCorrectString1));
            Assert.AreEqual(sb.LastIndexOf(string.Empty, startIndexCorrectString1, 55), correctStringToSearch1.LastIndexOf(string.Empty, startIndexCorrectString1, 55));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEmptyValueEmptyStringBuilderIndex()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOf(string.Empty, startIndexCorrectString1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEmptyValueEmptyStringBuilderIndexAndCount()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOf(string.Empty, startIndexCorrectString1, 55);
        }

        [TestMethod]
        public void TestValueLengthGreaterThanStringBuilderLengthContaining()
        {
            int startIndex = correctSmallStringToSearch.Length - 4;
            StringBuilder sb = new StringBuilder(correctSmallStringToSearch);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched), correctSmallStringToSearch.LastIndexOf(TestStrings.Searched));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndex), correctSmallStringToSearch.LastIndexOf(TestStrings.Searched, startIndex));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndex, 12), correctSmallStringToSearch.LastIndexOf(TestStrings.Searched, startIndex, 12));
        }

        [TestMethod]
        public void TestValueLengthGreaterThanStringBuilderLengthNotContaining()
        {
            int startIndex = incorrectSmallStringToSearch.Length - 4;
            StringBuilder sb = new StringBuilder(incorrectSmallStringToSearch);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched), incorrectSmallStringToSearch.LastIndexOf(TestStrings.Searched));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndex), incorrectSmallStringToSearch.LastIndexOf(TestStrings.Searched, startIndex));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, startIndex, 12), incorrectSmallStringToSearch.LastIndexOf(TestStrings.Searched, startIndex, 12));
        }

        [TestMethod]
        public void TestEmptyStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched), string.Empty.LastIndexOf(TestStrings.Searched));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, 0), string.Empty.LastIndexOf(TestStrings.Searched, 0));
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, 0, 55), string.Empty.LastIndexOf(TestStrings.Searched, 0, 55));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEmptyStringBuilderIndex()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEmptyStringBuilderIndexWithCount()
        {
            StringBuilder sb = new StringBuilder();
            sb.LastIndexOf(TestStrings.Searched, startIndexCorrectString1, 55);
        }

        [TestMethod]
        public void TestIndexFirstCharacter()
        {
            StringBuilder sb;
            sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, 0), TestStrings.ToIndexOfChars1.LastIndexOf(TestStrings.Searched, 0));
            sb = new StringBuilder(correctStringToSearch1);
            Assert.AreEqual(sb.LastIndexOf(TestStrings.Searched, 0), correctStringToSearch1.LastIndexOf(TestStrings.Searched, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacter()
        {
            StringBuilder sb = new StringBuilder(TestStrings.ToIndexOfChars1);
            sb.LastIndexOf(TestStrings.Searched, sb.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexAfterLastCharacterWithCount()
        {
            StringBuilder sb = new StringBuilder(correctStringToSearch1);
            sb.LastIndexOf(TestStrings.Searched, sb.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.Searched, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexLessThanZeroWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.Searched, -1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.Searched, sb.Length + 1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexGreaterThanMaximumWithCount()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.Searched, sb.Length + 1, 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountLessThanZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.Searched, 0, -1);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountEqualsZero()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.Searched, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCountGreaterThanMaximum()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.Searched, 0, sb.Length + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIndexPlusCountGreaterThanLength()
        {
            StringBuilder sb = new StringBuilder(TestStrings.Composition1);
            sb.LastIndexOf(TestStrings.Searched, 5, 20);
        }
    }
}
