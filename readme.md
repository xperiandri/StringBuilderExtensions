# String Builder Extensions #
String Builder Extensions is a set of extension methods for **[System.Text.StringBuilder](http://msdn.microsoft.com/en-us/library/system.text.stringbuilder.aspx)** that provide the same functionality as corresponding methods of **[System.String](http://msdn.microsoft.com/en-us/library/system.string.aspx)**.

Available methods are:

- **Remove** - Removes all occurences of specified characters from StringBuilder.
- **Remove** - Removes the range of characters from the specified index to the end of StringBuilder.
- **StartsWith** - Determines whether this instance of StringBuilder starts with the specified string.
- **EndWith** - Determines whether this instance of StringBuilder ends with the specified string.
- **IndexOf** (6 overrides) - Reports the zero-based index position of the first occurrence of the specified Unicode character within this instance.
- **LastIndexOf** (6 overrides) - Reports the zero-based index of the last occurrence of the specified string in the current StringBuilder object. 
- **IndexOfAny** (3 overrides) - Reports the zero-based index of the first occurrence in this instance of any character in a specified array of Unicode characters. 
- **LastIndexOfAny** (3 overrides) - Reports the zero-based index of the last occurrence in this instance of any character in a specified array of Unicode characters.
- **Trim** (2 overrides) - Removes all leading and trailing occurrences of a set of characters specified in an array from the current StringBuilder object.
- **TrimStart** - Removes all leading occurrences of a set of characters specified in an array from the current StringBuilder object.
- **TrimEnd** - Removes all trailing occurrences of a set of characters specified in an array from the current StringBuilder object.
- **ToLower** (2 overrides) - Returns a StringBuilder converted to lowercase, using the casing rules of the specified culture.
- **ToLowerInvariant** - Returns a StringBuilder converted to lowercase, using the casing rules of the invarian culture.
- **ToUpper** (2 overrides) - Returns a StringBuilder converted to uppercase, using the casing rules of the specified culture.
- **ToUpperInvariant** - Returns a StringBuilder converted to uppercase, using the casing rules of the invariant culture.