using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Question:IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }
        public Answer CorrectAnswer { get; set; }

        public Question(string header, string body, int mark, Answer[] answers, Answer correct)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answers;
            CorrectAnswer = correct;
        }

        public int CompareTo(Question other)
        {
            return this.Mark.CompareTo(other.Mark);
        }
        public virtual void Show() { }

    }
}
