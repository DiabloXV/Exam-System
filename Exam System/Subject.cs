using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_System
{
    public class Subject
    {
        public int SubjectId { get; private set; }

        public string? SubjectName { get; private set; }

        public Exam Exam { get; private set; }

        public Subject(int _subjectId, string _subjectname)
        {
            SubjectId = _subjectId;
            SubjectName = _subjectname;
        }

        public void CreateExam (Exam exam)
        {
            Exam = exam;
        }

        public override string ToString()
        {
            return $"\nSubjec ID : {SubjectId}, Subject{SubjectName}";
        }
    }
}
