using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    internal class AnswerList:List<Answer>,ICloneable,IComparable<AnswerList>
    {
        public AnswerList()
        {

        }
        public AnswerList(string[] answers = null)
        {
            if(answers!=null && answers.Length>0)
                foreach (string answer in answers)
                {
                    Add(new Answer(answer));
                }
        }
        public AnswerList(Answer[] answers = null)
        {
            if (answers != null && answers.Length > 0)
                foreach (Answer answer in answers)
                {
                    Add(answer);
                }
        }
        public override string ToString()
        {
            string answers = "";
            foreach (Answer ans in this)
                answers = answers + (ans?.answer?.Length > 0 ? " - " : "") + ans?.answer;
            return answers;
        }
        public void ShowAnswers()
        {
            int i = 1;
            foreach (var answer in this)
            {
                Console.WriteLine($"({i}) {answer}");
                i++;
            }
            Console.Write("\n");
        }

        public static implicit operator bool(AnswerList al)
        {
            return  al != null && al.Count > 0;
        }

        public object Clone()
        {
            if (this != null)
                return new AnswerList(ToArray());
            return new AnswerList();
        }
        public override bool Equals(object? obj)
        {
            AnswerList? al = obj as AnswerList;
            if(al!=null && this!=null)
            {
                if(Count != al.Count) return false;
                for(int i=0;i<al.Count; i++)
                {
                    if (!al[i].Equals(this[i]))
                        return false;
                }
                return true;

            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ToString());
        }

        public int CompareTo(AnswerList? other)
        {
            if(other && this)
            {
                return ToString().CompareTo(other.ToString());
            }
            return -1;
        }
    }
}
