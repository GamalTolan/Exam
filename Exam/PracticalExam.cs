using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class PracticalExam : Exam
    {
       public MCQQuestions[] MCQQuestions { get; set; }
        public PracticalExam(int time, int questionsNum) : base(time, questionsNum) { }


        
        public override void ShowExam()
        {

            Console.WriteLine($"Time: {Time} , Number of Questions: {NumberOfQuestions}");
            Console.WriteLine("MCQ Questions:");

            foreach (var question in Questions)
            {
                question.Show();
                Console.Write("Your Answer (1:4) : ");
                string userAnswer = Console.ReadLine();

                TheAnswer(question, userAnswer);

            }
            
        }

        public void TheAnswer(Question question, string userAnswer)
        {
            
            if (question.CorrectAnswer.AnswerText.Equals(userAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct Answer ");
            }
            else
            {
                Console.WriteLine($"Incorrect Answer,Correct answer is: {question.CorrectAnswer.AnswerText}");
            }
        }


    }
}
