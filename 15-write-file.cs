// https://csharp1.com/write-file/
// No w+ in C#, rewrite article!

using(StreamWriter writetext = new StreamWriter("write.txt"))
{
    writetext.WriteLine("writing in text file");
}