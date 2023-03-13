using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalTask
{
    internal class FinalExam:Exam
    {
        public FinalExam(Subject subject, int qnum):base(subject, ExamType.Final, qnum) {}

    }
}
