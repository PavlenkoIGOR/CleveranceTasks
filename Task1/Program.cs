// See https://aka.ms/new-console-template for more information
using Task1;


Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a string:");

//Compress
string compressedString = Console.ReadLine().CompressString();
Console.WriteLine($"Compressed string: {compressedString}");

//DeCompress
string decompressedString = compressedString.DecompressString();
Console.WriteLine($"DeCompressed string: {decompressedString}");

Console.ReadLine();


