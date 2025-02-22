using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class MCQQuestions : Question
    {


        public MCQQuestions(string header, string body, int mark, Answer[] answers, Answer correct): base("MCQ", body, mark, answers, correct)
        {
            

        }

        public override void Show()
        {
            Console.WriteLine($"{Header}: {Body} ({Mark} Marks)");

            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"The Answer is {answer}");
            }
        }

    }
}
