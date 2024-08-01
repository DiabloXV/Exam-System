using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    public class Answer
    {
        public int AnswerId { get; private set; }

        public string AnswerText { get; private set; }

        public Answer(int _answerId, string _answerText) 
        {
            AnswerId = _answerId;
            AnswerText = _answerText;
        }

        public override string ToString() 
        {
            return $"\tAnswerId: {AnswerId}, AnswerText:{AnswerText}";
        }
    }
}
