namespace FinalTask
{
    internal class ChooseOneQuestion : Question
    {

        public ChooseOneQuestion(string header, float marks,Answer QuestionAnswers, Answer ModelAnswer) : base(header, marks, QuestionAnswers, ModelAnswer, Type.ChooseOne)
        {
        }

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
