using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Text.Tests
{
    static class TestStrings
    {
        internal static readonly string WhiteSpacesTrimmed = "some string";
        internal static readonly string WhiteSpacesRemoved = "somestring";
        internal static readonly string LeadingWhiteSpaces = "  some string";
        internal static readonly string TrailingWhiteSpaces = "some string ";
        internal static readonly string LeadingAndTrailingWhiteSpaces = "    some string  ";
        internal static readonly string WhiteSpaces = "    ";

        internal static readonly char[] SymbolsToTrim = new char[] { '*', '^', '&' };
        internal static readonly string SymbolsTrimmed = "some*&^string";
        internal static readonly string SymbolsRemoved = "somestring";
        internal static readonly string LeadingSymbols = "*&^some*&^string";
        internal static readonly string TrailingSymbols = "some*&^string*&^";
        internal static readonly string LeadingAndTrailingSymbols = "&^*some*&^string&*^";
        
        internal static readonly string ToIndexOfChars1 = SymbolsTrimmed + LeadingSymbols;
        internal static readonly string ToIndexOfChars2 = LeadingSymbols + LeadingAndTrailingSymbols;
        
        internal static readonly string SingleCharacter = "!";
        internal static readonly string Searched = "mfsd42(*#D$#@cder23?"; // 20 symbols
        internal static readonly string Composition1 = "sfreewfr3c 4vtc"; // 15 symbols
        internal static readonly string Composition2 = "(dx D!@DWE 9&53 sr;'"; // 20 symbols
    }
}
