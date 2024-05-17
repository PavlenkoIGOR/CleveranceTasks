// See https://aka.ms/new-console-template for more information
using Task1;


Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a string:");

#region Compress
//Compress
string compressedString = Console.ReadLine().CompressString();
Console.WriteLine($"Compressed string: {compressedString}");

//Compress with stringBuilder
string compressedStringBuilder = compressedString.CompressString();
Console.WriteLine($"Compressed string by SB: {compressedStringBuilder}");
#endregion

#region Decompress
//DeCompress
string decompressedString = compressedString.DecompressString();
Console.WriteLine($"DeCompressed string: {decompressedString}");
#endregion

Console.ReadLine();


