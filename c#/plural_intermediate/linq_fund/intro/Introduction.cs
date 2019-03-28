using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            ShowLargeFilesWOLinq(path);
            Console.WriteLine("*****");
            ShowLargeFilesWLinq(path);
            Console.ReadLine();
        }

        private static void ShowLargeFilesWLinq(string path)
        {
            //var query = from file in new DirectoryInfo(path).GetFiles()
            //            orderby file.Length descending
            //            select file;

            //  looks like sql

            var query = new DirectoryInfo(path).GetFiles()
                        .OrderByDescending(f => f.Length)
                        .Take(5);

            //foreach (var file in query.Take(5))
            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");

            }
            //  just take 5 files from the query
            //  no new class needed!
        }

        private static void ShowLargeFilesWOLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());

            for(int x = 0; x < 5; x++)
            {
                FileInfo file = files[x];
                Console.WriteLine($"{file.Name, -20} : {file.Length, 10:N0}");
                // left justify file.Name in twenty spaces
                // right justify in a ten space comma
                // format as a number, 0 positions after the decimal point

            }
        }
    }


    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }


}
