using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
namespace System.Text.Tests
{
    [TestClass()]
    public class StartsWithTests
    {
        private static readonly string correctStringToSearch = string.Concat(TestStrings.Searched, TestStrings.Composition1, TestStrings.Searched, TestStrings.Composition2);
        private static readonly string correctStringToSearchUpperCase = string.Concat(TestStrings.Searched.ToUpper(), TestStrings.Composition1, TestStrings.Searched, TestStrings.Composition2);
        private static readonly string incorrectStringToSearch1 = string.Concat(TestStrings.SingleCharacter, TestStrings.Searched, TestStrings.Composition1, TestStrings.Composition2);
        private static readonly string incorrectStringToSearch2 = string.Concat(TestStrings.Composition1, TestStrings.Composition2);
        private static readonly string smallStringToSearch = TestStrings.Composition1;

        [TestMethod()]
        public void TestContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(correctStringToSearch);
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched), correctStringToSearch.StartsWith(TestStrings.Searched));
            sb = new StringBuilder(TestStrings.Searched);
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched), correctStringToSearch.StartsWith(TestStrings.Searched));
        }

        [TestMethod()]
        public void TestContainingCharactersIgnoreCase()
        {
            StringBuilder sb;
            sb = new StringBuilder(correctStringToSearchUpperCase);
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched, true), correctStringToSearch.StartsWith(TestStrings.Searched, true, CultureInfo.CurrentCulture));
            sb = new StringBuilder(TestStrings.Searched.ToUpper());
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched, true), correctStringToSearch.StartsWith(TestStrings.Searched, true, CultureInfo.CurrentCulture));
        }

        [TestMethod]
        public void TestNotContainingCharacters()
        {
            StringBuilder sb;
            sb = new StringBuilder(incorrectStringToSearch1);
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched), incorrectStringToSearch1.StartsWith(TestStrings.Searched));
            sb = new StringBuilder(incorrectStringToSearch2);
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched), incorrectStringToSearch2.StartsWith(TestStrings.Searched));
        }

        [TestMethod]
        public void TestNotContainingCharactersIgnoreCase()
        {
            StringBuilder sb;
            sb = new StringBuilder(incorrectStringToSearch1);
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched, true), incorrectStringToSearch1.StartsWith(TestStrings.Searched, true, CultureInfo.CurrentCulture));
            sb = new StringBuilder(incorrectStringToSearch2);
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched, true), incorrectStringToSearch2.StartsWith(TestStrings.Searched, true, CultureInfo.CurrentCulture));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullValue()
        {
            StringBuilder sb = new StringBuilder();
            sb.StartsWith(null);
        }

        [TestMethod]
        public void TestEmptyValue()
        {
            StringBuilder sb = new StringBuilder();
            Assert.IsTrue(sb.StartsWith(string.Empty));
        }

        [TestMethod]
        public void TestValueLengthGreaterThanStringBuilderLength()
        {
            StringBuilder sb = new StringBuilder(smallStringToSearch);
            Assert.AreEqual(sb.StartsWith(TestStrings.Searched), smallStringToSearch.StartsWith(TestStrings.Searched));
        }

        [TestMethod]
        public void TestEmpty()
        {
            StringBuilder sb = new StringBuilder();
            Assert.IsFalse(sb.StartsWith(TestStrings.Searched));
        }
    }
}
