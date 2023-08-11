// See https://aka.ms/new-console-template for more information
using ExtensionExample;

Console.WriteLine("Hello, World!");

String upperString = "UPPER STRING";

Console.WriteLine("Is "+ upperString+ "  uppaerCase== " + StringExtension.StartsWithUpperCase(upperString));

String lowerString = "lower string";

Console.WriteLine("Is "+ lowerString + " uppaerCase == " + StringExtension.StartsWithUpperCase(lowerString));
