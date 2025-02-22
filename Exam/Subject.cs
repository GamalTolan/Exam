using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Subject 
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam Exam { get; set; }

        public Subject(int SubId, string SubName)
        {
            SubjectId = SubId;
            SubjectName = SubName;
        }


        public void AddExam()
        {
          
            Console.WriteLine("Select Exam Type: 1. Final Exam  2. Practical Exam");
            int choice = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter Number of Questions:");
            int numOfQuestions = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Time (in minutes):");
            int time = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Exam = new FinalExam(time, numOfQuestions);
            }
            else 
            {
                Exam = new PracticalExam(time, numOfQuestions);
            }


            for (int i = 0; i < numOfQuestions; i++)
            {
              
                if (choice == 1) // final
                {
                    Console.WriteLine("Select Question Type: 1. True/False  2. MCQ");
                    int QuestionType = int.Parse(Console.ReadLine());

                    if (QuestionType == 1) 
                    {
                        Console.Write("Enter Mark: ");
                        int mark = int.Parse(Console.ReadLine());

                        Console.Write("Enter Question Body: ");
                        string body = Console.ReadLine();

                       

                        Console.Write("Enter Correct Answer (True/False): ");
                        string correct = Console.ReadLine();
                            Answer[] answers = new Answer[]
                            {
                                new Answer(1, "True"),
                                new Answer(2, "False")
                            };
                        Answer correctAnswer = correct.Equals("True", StringComparison.OrdinalIgnoreCase) ? answers[0] : answers[1];
                        

                        Exam.Questions[i] = new TrueOrFalseQuestion("True/False", body, mark, answers, correctAnswer);
                    }
                    else
                    {
                        Console.Write("Enter Question : ");
                        string body = Console.ReadLine();

                        Console.Write("Enter Mark: ");
                        int mark = int.Parse(Console.ReadLine());

                        Console.Write("Enter Choice 1: ");
                        string Choice01 = Console.ReadLine();
                        Console.Write("Enter Choice 2: ");
                        string Choice02 = Console.ReadLine();
                        Console.Write("Enter Choice 3: ");
                        string Choice03 = Console.ReadLine();
                        Console.Write("Enter Choice 4: ");
                        string Choice04 = Console.ReadLine();

                        

                        Console.Write("Enter The Number of Correct Choice : ");
                       int correct =int.Parse(Console.ReadLine());

                        Exam.Questions[i] = new MCQQuestions("MCQ", body, mark,new Answer[]
                                                                                { new Answer(1, Choice01), 
                                                                                    new Answer(2, Choice02),
                                                                                    new Answer(3, Choice03),
                                                                                    new Answer(4, Choice04) },
                                                                              new Answer(correct, correct == 1 ? Choice01 : correct == 2 ? Choice02 : correct == 3 ? Choice03 : Choice04));
                    }


                }

                else //practical
                {
                    

                    Console.Write("Enter Question Body: ");
                    string body = Console.ReadLine();

                    Console.Write("Enter Mark: ");
                    int mark = int.Parse(Console.ReadLine());

                    Console.Write("Enter Choice 1: ");
                    string Choice01 = Console.ReadLine();
                    Console.Write("Enter Choice 2: ");
                    string Choice02 = Console.ReadLine();
                    Console.Write("Enter Choice 3: ");
                    string Choice03 = Console.ReadLine();
                    Console.Write("Enter Choice 4: ");
                    string Choice04 = Console.ReadLine();

                    Console.Write("Enter The Number of Correct Answer : ");
                    int correct = int.Parse(Console.ReadLine()) ;

                    Exam.Questions[i] = new MCQQuestions("mcq", body, mark, new Answer[]
                                                                            { new Answer(1, Choice01),
                                                                                new Answer(2, Choice02),
                                                                                new Answer(3, Choice03),
                                                                                new Answer(4, Choice04) },
                                                                              new Answer(correct, correct == 1 ? Choice01 : correct == 2 ? Choice02 : correct == 3 ? Choice03 : Choice04));


                }

            }
        }
    }
}

    
    


