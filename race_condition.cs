using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\camed\Desktop\examplefile.txt";
        if(!File.Exists(path))
        {
            File.Create(path);
        }
    }
}
