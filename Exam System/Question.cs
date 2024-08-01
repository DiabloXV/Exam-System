using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_System;

namespace Exam_System
{
    public abstract class Question
    {
        public string Header { get; set; }

        public string Body { get; set; }

        public int Mark {  get; set; }

        public Answer[] Answers { get; private set; }


        protected Question(string _header, string _body, int _mark, int _answerCapacity)
        {
            Header = _header;
            Body = _body;
            Mark = _mark;
            Answers = new Answer[_answerCapacity];
        }

        public void AddAnswer(Answer answer)
        {
            for (int i = 0; i < Answers.Length; i++) 
            {
                if (Answers[i] == null)
                {
                    Answers[i] = answer;
                    return;
                }
                
            }
            throw new Exception("Answer array is full");
        }

        public virtual bool CheckAnswer(int answerId)
        {
            foreach (var answer in Answers)
            {
                if (answer is not null & answer.AnswerId == answerId)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString() 
        {
            return $"<<\n{Header}   :   {Body}\n>>";
        }

    }

    public class TrueFalse : Question
    {
        private int CorrectAnswerId {  get; set; }

        public TrueFalse(string _header, string _body, int _mark, int correctAnswerId) : base(_header, _body, _mark, 2)
        { 
            CorrectAnswerId = correctAnswerId;
        }

        public override bool CheckAnswer(int answerId)
        {
            return answerId == CorrectAnswerId;
        }

    }

    public class MCQ : Question 
    {
        private int CorrectAnswerId { get; set; }

        public MCQ(string _header, string _body, int _mark, int correctAnswerId, int _answerCapacity) : base(_header, _body, _mark, _answerCapacity)
        {
            CorrectAnswerId= correctAnswerId;
        }

        public override bool CheckAnswer(int answerId)
        {
            return answerId == CorrectAnswerId;
        }
    }
    
}



