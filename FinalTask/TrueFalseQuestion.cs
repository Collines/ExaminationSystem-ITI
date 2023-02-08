namespace FinalTask
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, float marks, Answer ModelAnswer) : base(header, marks, new Answer(new string[] { "True", "False" }), ModelAnswer,Type.TrueFalse)
        {}
        public override bool Correct(Answer EnteredAnswer)
        {
            if (EnteredAnswer.Get().Length == 1) 
            {
                if (EnteredAnswer.Get()[0] == ModelAnswers.Get()[0])
                    return true;
            }
            return false;
        }

    }
}
