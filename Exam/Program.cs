using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Subject Sub1 = new Subject(5, "Math");
            Sub1.AddExam();
            Console.Clear();

            Console.Write("Do You Want To Start The Exam (y | n): ");
            char userInput = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            if (char.ToLower(userInput) == 'y')
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
 
               Sub1.Exam.ShowExam();
                SW.Stop();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed} seconds");
            }
           
        }

    }
    
}
