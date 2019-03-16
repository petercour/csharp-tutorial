using System.IO;

// https://csharp1.com/file-exists/
string path = @"file.txt";
if (File.Exists(path))
{
    Console.WriteLine("File exists");
} else {
    Console.WriteLine("File does not exist");
}