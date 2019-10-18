using System;
//using System.Speech.Synthesis;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello! This is the gradebook program");






            //GradeBook book = new GradeBook();
            GradeBook book = new ThrowAwayGradeBook();
            // this is legal since its a type 

            GetBookName(book);



            //book.Name = "Scott's Grade Book";
            // if field is public
            //book.Name = null;
            // property ignores this

            Console.WriteLine(book.Name);
            AddingGrades(book);

            StreamWriter outputFile = File.CreateText("gradesz.txt");
            book.WriteGrades(outputFile);
            outputFile.Close();
            // this never created the text

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);


        }

        private static void AddingGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Bad thing");
            }
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }


        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }


        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");

            //Console.WriteLine("{0}: {1:F2}", description, result);
            // formatting string!
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");

            //Console.WriteLine("{0}: {1:F2}", description, result);
            // formatting string!
        }

        //static void WriteResult(string description, params float[] result)
        //{
        //    Console.WriteLine(description + ": " + result);
        //}
    }

}
