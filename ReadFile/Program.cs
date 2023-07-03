using System;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();
            FileInfo fileInfo = new FileInfo($"{path}\\json.txt");
            string textFile;
            using (var streamReaderFile = new StreamReader(fileInfo.FullName))
            {
                textFile = streamReaderFile.ReadToEnd();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
