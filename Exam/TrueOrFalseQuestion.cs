using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string header, string body, int mark, Answer[] answers,Answer correct) : base("True/False", body, mark, new Answer[] { new Answer(1, "True"), new Answer(2, "False") }, correct) { }


        public override void Show()
        {
            Console.WriteLine($"{Header}: {Body} ({Mark} Marks)");

            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
            }
        }
    }
    
    
}
