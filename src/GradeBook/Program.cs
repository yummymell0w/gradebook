using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Margo's Grade Book");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;


            while (true)
            {
                Console.WriteLine("Please enter a grade or 'q' to quit.");
                var input = Console.ReadLine();


                if (input == "q")
                {
                    break;
                }

                try
                {
                var grade = double.Parse(input);
                book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }


            var stats = book.GetStatistics();
            book.Name = "";

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"The book name {book.Name}");
            Console.WriteLine($"The highest grade is {stats.High}.");
            Console.WriteLine($"The lowest grade is {stats.Low}.");
            Console.WriteLine($"The average grade is {stats.Average:N1}.");
            Console.WriteLine($"The average grade is {stats.Letter}.");

        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added.");
        }
    }
}
