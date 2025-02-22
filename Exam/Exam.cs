using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Exam:ICloneable
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int time ,int questionsNum) 
        { 
            Time = time;
            NumberOfQuestions = questionsNum;
            Questions = new Question[questionsNum];
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

      
        public virtual void ShowExam(){ }

        public override string ToString()
        {
           return $"Time: {Time} , Number of Questions: {NumberOfQuestions}";
        }
    }
}
