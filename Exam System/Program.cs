namespace Exam_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            string timee = time.ToString("HH:mm:ss");

            //Creating a Final Exam
            
            //1.Create subject
            Subject subject = new Subject(1, "Computer Science");

            #region Final Exam Creation Example
            //2. Create a Final Exam
            FinalExam finalexam = new FinalExam(timee);

            //3.create T\F Question
            TrueFalse Q1 = new TrueFalse("True/False", "Is class a reference type object?", 5 , 1);
            Q1.AddAnswer(new Answer(1, "True"));
            Q1.AddAnswer(new Answer(2,"False'"));

            //4. create MCQ Question
            MCQ Q2 = new MCQ("MCQ", "Which of the following is an OOP pillar?", 10, 3, 3);
            Q2.AddAnswer(new Answer(1, "Implementaion"));
            Q2.AddAnswer(new Answer(2, "Guidance"));
            Q2.AddAnswer(new Answer(1, "Polymorphism"));

            finalexam.AddQuestion(Q1);
            finalexam.AddQuestion(Q2);
            subject.CreateExam(finalexam);

            //Showing Exam details
            finalexam.ShowExam();
            Console.WriteLine(finalexam.ToString());

            //Showing Subject details
            Console.WriteLine(subject);
            #endregion

            #region Practical Exam Creation Example
            PracticalExam Pexam = new PracticalExam(timee);

            MCQ PQ1 = new MCQ("MCQ", "What is the only possible relation between a concrete class and an abstract class?", 10, 2,3);
            PQ1.AddAnswer(new Answer(1, "Inheritance only"));
            PQ1.AddAnswer(new Answer(2, "Inheritance and Implementation"));
            PQ1.AddAnswer(new Answer(3, "Implemention only"));

            Pexam.AddQuestion(PQ1);

            subject.CreateExam(Pexam);

            Pexam.ShowExam();
            Console.WriteLine(Pexam.ToString());

            Console.WriteLine(subject);
            subject.ToString();

            #endregion
        }
    }
}
