namespace FinalTask
{
    class Practical : Exam
    {

        public Practical(Subject subject):base(subject) 
        {
            Type = ExamType.Practical;
        }

        public static implicit operator bool(Practical x)
        {
            if (x.Subj)
                return true;
            return false;
        }
        public float GetExamMarks()
        {
            float marks = 0;
            if (Subj.Questions.Count > 0)
            {
                for (int i = 0; i < Subj.Questions.Count; i++)
                {
                    marks += Subj.Questions[i].GetMarks();
                }
            }
            return marks;
        }
        public override void StartExam()
        {
            base.StartExam();
            Console.WriteLine("\nCorrect Ansers:");
            string qnum;
            for (int i = 0; i < Subj.Questions.Count; i++)
            {
                qnum = $"{i + 1}";
                Subj.Questions[i].ShowCorrectAnswers(qnum);
            }

        }

    }
}
