using FinalTask;

#region TrueFalseQuestion Test is working
//Answer ModelAnswer = new Answer(new string[] { "False" });
//Question Q1 = new TrueFalseQuestion("Is mohamed 25?", 10, ModelAnswer);
//Console.WriteLine(Q1.Correct(new Answer(new string[] { "True" })));
#endregion

#region MultipleQuestion Test working
//Answer QuestionAnswers = new Answer(new string[] { "Dog", "Cow", "Bird","Crocodile","Goat","Lizard" });
//Answer ModelAnswers = new Answer(new string[] { "Dog", "Cow", "Goat" });
//Answer EnteredAnswers = QuestionAnswers.Grab(new string[] {"5", "1", "2" });
//Question Q2 = new ChooseMultiple("Choose Mammals:", 10, QuestionAnswers, ModelAnswers);
//Console.WriteLine(Q2.Correct(EnteredAnswers));
#endregion

#region One Question Test 
//Answer QuestionAnswers = new Answer(new string[] { "Dog", "Cow", "Bird","Crocodile","Goat","Lizard" });
//Answer ModelAnswer = new Answer(new string[] { "Cow"});
//Question Q1 = new ChooseOneQuestion("Is mohamed 25?", 10,QuestionAnswers, ModelAnswer);
//Console.WriteLine(Q1.Correct(QuestionAnswers.Grab(new string[] {"3"})));
#endregion

byte choice;
Subject Subj;
IExam Exam;
int i = 1;
string[] keys = QuestionsHandler.GetKeys(); // GET SUBJECT NAMES (keys)
do
{
    Console.WriteLine("Enter the subject you want to be tested in");
    foreach (var key in keys)
    {
        Console.WriteLine($"{i}. {key}"); // printing subject names to make user choose from them
        i++;
    }
    Console.WriteLine("0. Exit");
    while (!byte.TryParse(Console.ReadLine(), out choice) || choice > keys.Length || choice < 0)
    {
        Console.WriteLine("Enter a valid number");
    }
    if (choice != 0)
    {
        Subj = new Subject(keys[choice - 1], QuestionsHandler.GetQuestions(keys[choice - 1]));
        Console.WriteLine("Enter Exam type \n1.Practical\n2.Final");
        while (!byte.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
        {
            Console.WriteLine("Enter a valid number");
        }
        if (Subj)
        {
            switch (choice)
            {
                case 1:
                    Exam = new Practical(Subj);
                    Exam.StartExam();
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Exam = new Exam(Subj);
                    Exam.StartExam();
                    Console.WriteLine("\n");
                    break;
                default:
                    Exam = null;
                    break;
            }
        }
    }
    i = 1;
} while (choice != 0);
