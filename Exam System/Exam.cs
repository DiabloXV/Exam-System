using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    public abstract class Exam 
    {
        private Question[] questions;

        public string TimeOfExam { get; private set; }

        public int NumberOfQuestions { get; private set; }


        public Exam(string timeOfExam) 
        {
            TimeOfExam = timeOfExam;
            questions = new Question[0];
            NumberOfQuestions = 0;
        }

        //public object Clone()
        //{
        //    throw new NotImplementedException();
        //}

        //public int CompareTo(Exam? other)
        //{
        //    throw new NotImplementedException();
        //}

        public void AddQuestion(Question question)
        {
            if(question == null) 
            {
                throw new Exception("Question Cannot be null");
            }
            Array.Resize(ref questions, NumberOfQuestions + 1);
            questions[NumberOfQuestions++] = question;
        }

        public Question[] GetQuestions()
        {
            return questions;
        }

        public abstract void ShowExam();

        public override string ToString()
        {
            return $"Time Of Exam: {TimeOfExam}, Number Of Questions: {NumberOfQuestions}";
        }

    }

    public class PracticalExam : Exam
    {
        public PracticalExam(string timeOfExam) : base(timeOfExam) { }

        public override void ShowExam() 
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t[[Practical Exam]]");
            foreach (var question in GetQuestions()) 
            {
                if(question is not null)
                {
                    Console.WriteLine(question);
                    foreach (var answer in question.Answers)
                    {
                        if (answer is not null)
                        {
                            Console.WriteLine(answer);
                            if(question.CheckAnswer(answer.AnswerId))
                            {
                                Console.WriteLine("\t\t\t|");
                                Console.WriteLine("\t\t\tV");
                                Console.WriteLine("\t\tCorrect Answer\n");
                            }

                        }
                    }
                }
            }
        }
    }
}
