namespace FinalTask
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, float marks, AnswerList ModelAnswer) : base(header, marks, new AnswerList(new string[] { "True", "False" }), ModelAnswer, QuestionType.TrueFalse)
        {}
        //public override bool Correct(Answer EnteredAnswer)
        //{
        //    if (EnteredAnswer.Get().Length == 1) 
        //    {
        //        if (EnteredAnswer.Get()[0] == ModelAnswers.Get()[0])
        //            return true;
        //    }
        //    return false;
        //}

    }
}
