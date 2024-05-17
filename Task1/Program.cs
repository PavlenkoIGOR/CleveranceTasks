// See https://aka.ms/new-console-template for more information
using Task1;


Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a string:");
//string strForCompress = Console.ReadLine();

string compressedString = Console.ReadLine().CompressedString();
Console.WriteLine($"Compressed string: {compressedString}");
Console.ReadLine();


