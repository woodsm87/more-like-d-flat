using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
    // File and FileInfo
            var path = @"c\temp\myfile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }


    // Directory and DirectoryInfo
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
            
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach(var folder in directories)
            {
                Console.WriteLine(folder);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

    // Path
            var paths = @"c:\projects\CsharpFundamentals\Helloworld\Helloworld.sln";
            var dotIndex = paths.IndexOf('.');
            var pathExtension = paths.Substring(dotIndex);

            Console.WriteLine("Extension: " + pathExtension);
            Console.WriteLine("Extension: " + Path.GetExtension(paths));
            Console.WriteLine("File Name: " + Path.GetFileName(paths));
            Console.WriteLine("Just file name: " + Path.GetFileNameWithoutExtension(paths));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(paths));

        }
    }
}
