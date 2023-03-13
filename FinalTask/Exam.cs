using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    enum ExamType : byte
    {
        Final,
        Practical
    }
    enum ExamStatus:byte // future implementation
    {
        NotStarted,
        Queued,
        Starting,
        Finished
    }
    internal abstract class Exam
    {
        public Subject Subj { get; protected set; }
        public ExamType Type { get; protected set; }
        public ExamStatus status { get; protected set; }
        public int QuestionNum { get; protected set; }

        public Exam(Subject subject,ExamType type, int questionNum)
        {
            Subj = subject;
            Type = type;
            status = ExamStatus.NotStarted;
            QuestionNum = questionNum;
        }
        public static implicit operator bool(Exam e)
        {
            if (e!= null && e.Subj)
                return true;
            return false;
        }

        protected float GetFullMarks(QuestionList Ql)
        {
            float marks = 0;
            if (QuestionNum > 0 && Ql.Count == QuestionNum)
            {
                for (int i = 0; i < Ql.Count; i++)
                {
                    marks += Ql[i].GetMarks();
                }
            }
            return marks;
        }
        public void ChangeStatus() // future implementation
        {
            switch(status)
            {
                case ExamStatus.NotStarted:
                    status = ExamStatus.Queued;
                break;
                case ExamStatus.Queued:
                    status = ExamStatus.Starting; 
                break;
                case ExamStatus.Starting:
                    status = ExamStatus.Finished;
                break;
                default: status = ExamStatus.NotStarted;
                break;
            }
        }
        public virtual void StartExam()
        {
            Dictionary<Question, AnswerList> Questions = new Dictionary<Question, AnswerList>();
            float studentMarks = 0;
            // Generating random questions
            Random rand = new Random();
            QuestionList randomQuestions = new QuestionList(Subj.Name, Subj.Questions.GetRange(0, QuestionNum).OrderBy(_ => rand.Next()).ToArray());

            // Getting Exam fullmark based on Exam questions
            float totalMarks = GetFullMarks(randomQuestions);

            // starting exam
            string qnum;
            Console.WriteLine($"\t\t\t\t{Subj.Name} {Type.ToString()} Exam - {Subj.Questions.Count} Questions - ({totalMarks} Marks)");
            Console.WriteLine("\t\t\tEnter question answers for multiple answers as following: 1,2,3 ..etc");
            for (int i = 0; i < randomQuestions.Count; i++)
            {
                qnum = $"{i + 1}";
                randomQuestions[i].ShowQuestion(qnum);
                string[] enteredIndexes;
                bool exit = true;
                do
                {
                    enteredIndexes = Console.ReadLine().Split(',');
                    if (enteredIndexes.Length > randomQuestions[i].GetQuestionAnswers().Count)
                    {
                        Console.WriteLine("Enter a valid input");
                        exit = false;
                    }
                    else
                        for (int j = 0; j < enteredIndexes.Length; j++)
                        {
                            if (!int.TryParse(enteredIndexes[j], out int x) || int.Parse(enteredIndexes[j])<=0 || int.Parse(enteredIndexes[j]) > randomQuestions[i].GetQuestionAnswers().Count)
                            {
                                Console.WriteLine("Enter a valid input");
                                exit = false;
                            }
                            else exit = true;
                        }
                } while (enteredIndexes.Length <= 0 ||
                    enteredIndexes.Length > randomQuestions[i].GetQuestionAnswers().Count || !exit);
                AnswerList EnteredAns = new AnswerList();
                for (int k = 0; k < enteredIndexes.Length; k++)
                {
                    EnteredAns.Add(randomQuestions[i].GetQuestionAnswers()[int.Parse(enteredIndexes[k]) - 1]);
                }
                Questions.Add(randomQuestions[i], EnteredAns);
                studentMarks = CorrectExam(Questions);
            }

            if(Type == ExamType.Practical)
            {
                int counter = 1;
                Console.WriteLine("         MODEL ANSWERS");
                foreach(KeyValuePair<Question,AnswerList> item in Questions)
                {
                    Console.WriteLine($"{counter}) {item.Key.GetModelAnswers()}");
                    counter++;
                }
            }
            if ((studentMarks / totalMarks) >= 0.7f)
                Console.WriteLine($"\n\t\tCongratulations! You've finished the exam and you got {studentMarks}/{totalMarks} Marks");
            else
                Console.WriteLine($"\n\t\tSorry! You Unfortunately failed the exam and you got {studentMarks}/{totalMarks} Marks");


        }
        protected float CorrectExam(Dictionary<Question, AnswerList> Questions)
        {
            float marks = 0;
            foreach (var entry in Questions)
            {
                if (entry.Key.GetModelAnswers().Equals(entry.Value))
                {
                    marks += entry.Key.GetMarks();
                }
            }
            return marks;
        }



    }
}