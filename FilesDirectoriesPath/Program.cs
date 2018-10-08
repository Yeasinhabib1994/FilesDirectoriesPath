using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDirectoriesPath
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists(@"C:\Users\yeasi\OneDrive\Desktop\folder"))
            {
                if (File.Exists(@"C:\Users\yeasi\OneDrive\Desktop\folder\file.txt"))
                {
                    File.Delete(@"C:\Users\yeasi\OneDrive\Desktop\folder\file.txt");
                }

                if (File.Exists(@"C:\Users\yeasi\OneDrive\Desktop\folder\fileInfo.txt"))
                {
                    File.Delete(@"C:\Users\yeasi\OneDrive\Desktop\folder\fileInfo.txt");
                }

                Directory.Delete(@"C:\Users\yeasi\OneDrive\Desktop\folder");
            }
            Directory.CreateDirectory(@"C:\Users\yeasi\OneDrive\Desktop\folder");
            if (File.Exists(@"C:\Users\yeasi\source\repos\file.txt"))
            {
                File.Copy(@"C:\Users\yeasi\source\repos\file.txt", @"C:\Users\yeasi\OneDrive\Desktop\folder\file.txt", true);
            }

            var path = @"C:\Users\yeasi\OneDrive\Desktop\folder\file.txt";
            var content = File.ReadAllText(path);
            Console.WriteLine(content);

            var fileInfo = new FileInfo(path); // Use fileInfo when done multiple operation on file. Because in case of fileInfo security checking is done only the first time.
            fileInfo.CopyTo(@"C:\Users\yeasi\OneDrive\Desktop\folder\fileInfo.txt");

            var files = Directory.GetFiles(@"C:\Users\yeasi\OneDrive\Desktop\folder", ".", SearchOption.AllDirectories);// you can also search by .txt or .jpg etc.
            foreach (var file in files)
                Console.WriteLine(file); // returns location of every file

            var directories = Directory.GetDirectories(@"C:\Users\yeasi\OneDrive\Desktop", ".", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory); // returns the directoris

            /*var directoryInfo = new DirectoryInfo(@"C:\Users\yeasi\OneDrive\Desktop\folder"); //You can also use DirectoryInfo operator.
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();*/

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("file name: " + Path.GetFileName(path));
            Console.WriteLine("file name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("directory name: " + Path.GetDirectoryName(path));
        }
    }
}
