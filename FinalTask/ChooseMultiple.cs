namespace FinalTask
{
    internal class ChooseMultiple : Question
    {
        public ChooseMultiple(string header,float marks, AnswerList questionAnswers, AnswerList modelAnswers):base(header,marks,questionAnswers,modelAnswers, QuestionType.Multiple)
        {}
      
    }
}
