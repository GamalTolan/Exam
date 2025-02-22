using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class FinalExam : Exam
    {
        public TrueOrFalseQuestion[] TrueOrFalseQuestion { get; set; }
        public MCQQuestions[] MCQQuestions { get; set; }
        public FinalExam(int time, int questionsNum) : base(time, questionsNum)
        {
            TrueOrFalseQuestion = new TrueOrFalseQuestion[questionsNum];
            MCQQuestions = new MCQQuestions[questionsNum];
        }


        public override void ShowExam()
        {

            Console.WriteLine($"Time: {Time} , Number of Questions: {NumberOfQuestions}");
            Console.WriteLine("True or False Questions:");
             
            foreach (var question in Questions)
            {
                if (question is TrueOrFalseQuestion)
                { 
                    question.Show();
                Console.Write("Your Answer (True/False): ");
                string userAnswer = Console.ReadLine();
                
                TheAnswer(question, userAnswer);
                }

                
            }

            Console.WriteLine("MCQ Questions:");
            foreach (var question in Questions)
            {
                if (question is MCQQuestions)
                {
                    question.Show();
                    Console.Write("Your Answer (1:4) : ");
                    string userAnswer = Console.ReadLine();
                    TheAnswer(question, userAnswer);
                }
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
                Console.WriteLine($"Incorrect Answer , Correct answer is: {question.CorrectAnswer.AnswerText}");
            }



        }


    }
}

    
    

