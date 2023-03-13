using FinalTask;

Dictionary<string, QuestionList> Questions = new Dictionary<string, QuestionList> {
            {"General Information", new QuestionList("General Information", new Question[]
            {
                    new TrueFalseQuestion("Sea otters have a favorite rock they use to break open food",2.5f,new AnswerList(new string[]{"True"})),
                    new TrueFalseQuestion("The blue whale is the biggest animal to have ever lived",2.5f,new AnswerList(new string[]{"True"})),
                    new TrueFalseQuestion("Pigs roll in the mud because they don’t like being clean",2.5f,new AnswerList(new string[]{"False"})),
                    new TrueFalseQuestion("Bats are blind",2.5f,new AnswerList(new string[]{"False"})),
                    new ChooseOneQuestion("Identify the capital city of Ecuador",2.5f,new AnswerList(new string[] { "Bogotá", "Tegucigalpa", "Quito", "Asunción" }),new AnswerList(new string[] { "Quito" })),
                    new ChooseOneQuestion("Identify the capital city of Portugal",2.5f,new AnswerList(new string[] { "Rome", "Lisbon", "Paris", "Madrid" }),new AnswerList(new string[] { "Lisbon" })),
                    new ChooseOneQuestion("Identify the capital city of Vietnam",2.5f,new AnswerList(new string[] { "Vientián", "Phnom Penh", "Bangkok", "Hanói" }),new AnswerList(new string[] { "Hanói" })),
                    new ChooseOneQuestion("Identify the capital city of Egypt",2.5f,new AnswerList(new string[] { "Beni-suef", "Alexandria", "Cairo", "Aswan" }),new AnswerList(new string[] { "Cairo" })),
                    new ChooseOneQuestion("What is name of the young rabbit?",2.5f,new AnswerList(new string[] { "Buck", "Doe", "Bunny", "Cottontail" }),new AnswerList(new string[] { "Bunny" })),
                    new ChooseMultiple("I _____ alcohol, but today I _____ my birthday.",5f,new AnswerList(new string[] { "'m not often drinking", "'m celebrating", "celebrate", "don't often drink" }),new AnswerList(new string[] {  "don't often drink","'m celebrating" })),
                    new ChooseMultiple("I don't really like _____ milk. I only like _____ milk that you buy.",5f,new AnswerList(new string[] { "the", "the", "–" }),new AnswerList(new string[] { "the", "–" })),

            })
            },
            {"Maths", new QuestionList("Maths", new Question[]
            {
                    new ChooseOneQuestion("12 * 9 / 4 = ?",2.5f,new AnswerList(new string[] { "25", "26", "27", "28" }),new AnswerList(new string[] { "27" })),
                    new ChooseOneQuestion("What number should come next: 14, 28, 20, 40, 32, 64,... ",2.5f,new AnswerList(new string[] { "52", "56", "96", "128" }),new AnswerList(new string[] { "56" })),
                    new TrueFalseQuestion("55 * 3 < 820 / 4 ?",2.5f,new AnswerList(new string[]{"True"})),
                    new ChooseOneQuestion("3 + 27 * 2 = ?",2.5f,new AnswerList(new string[] { "33", "54", "57", "60" }),new AnswerList(new string[] { "57" })),
                    new ChooseOneQuestion("What number should come next: 7, 10, 8, 11, 9, 12,... ",2.5f,new AnswerList(new string[] { "7", "10", "12", "13" }),new AnswerList(new string[] { "10" })),
                    new ChooseMultiple("8 * 2 * 15 / 4 = ?",5f,new AnswerList(new string[] { "60", "240 / 6", "480 / 8", "15 * 3" }),new AnswerList(new string[] {  "60","480 / 8" })),
                    new TrueFalseQuestion("4232 > 8520 / 2 ?",2.5f,new AnswerList(new string[]{"False"})),
                    new ChooseOneQuestion("What number should come next: 31, 29, 24, 22, 17,... ",2.5f,new AnswerList(new string[] { "15", "14", "13", "12" }),new AnswerList(new string[] { "15" })),
                    new ChooseOneQuestion("1080 / ? = 9 * 8",2.5f,new AnswerList(new string[] { "13", "15", "17", "19" }),new AnswerList(new string[] { "15" })),
                    new ChooseMultiple("Which is the factorial of 4 ?",5f,new AnswerList(new string[] { "22", "24", "8 * 3", "12 * 2" }),new AnswerList(new string[] { "24", "8 * 3", "12 * 2" })),

            })
            },
            {"English", new QuestionList("English",new Question[]
            {
                new ChooseMultiple("______ there anybody in the room?. Nowadays everyone ______ internet.", 5f, new AnswerList(new string[] { "Are", "is", "had used", "uses" }), new AnswerList(new string[] { "is", "uses" })),
                    new ChooseOneQuestion("I spoke to", 2.5f, new AnswerList(new string[] { "she", "her", "he" }), new AnswerList(new string[] { "her" })),
                    new ChooseOneQuestion("I am seeing her ____ three o'clock.", 2.5f, new AnswerList(new string[] { "in", "at", "on" }), new AnswerList(new string[] { "at" })),
                    new ChooseOneQuestion("___ girlfriend left him.", 2.5f, new AnswerList(new string[] { "He", "His", "Him" }), new AnswerList(new string[] { "His" })),
                    new ChooseOneQuestion("I came _____ America.", 2.5f, new AnswerList(new string[] { "from", "at", "in" , "on" }), new AnswerList(new string[] { "from" })),
                    new TrueFalseQuestion("A RIVER is bigger than a STREAM.", 2.5f, new AnswerList(new string[] { "True" })),
                    new TrueFalseQuestion("There are one thousand years in a CENTURY", 2.5f, new AnswerList(new string[] { "False" })),
                    new TrueFalseQuestion("EQUIVALENT TO is (more or less) the same as EQUAL TO", 2.5f, new AnswerList(new string[] { "True" })),
                    new TrueFalseQuestion("USED TO DOING and USED TO DO mean the same thing.", 2.5f, new AnswerList(new string[] { "False" })),
                    new ChooseMultiple("She is____ home. And She eats___ apple..", 5f, new AnswerList(new string[] { "in", "at", "a", "an" }), new AnswerList(new string[] { "at", "an" })),

            })
            },

        };
//Question Q = new ChooseOneQuestion("Identify the capital city of Ecuador", 2.5f, new AnswerList(new string[] { "Bogotá", "Tegucigalpa", "Quito", "Asunción" }), new AnswerList(new string[] { "Quito" }));
//Q.GetQuestionAnswers().ShowAnswers();


//QuestionList eng = new QuestionList("English");
//foreach(var e in Questions["English"])
//{
//    eng.Add(e);
//}
//QuestionList Maths = new QuestionList("Maths");
//foreach (var e in Questions["Maths"])
//{
//    Maths.Add(e);
//}


Exam exam;
byte choice;
Subject Subj;
int i = 1;
string[] keys = Questions.Keys.ToArray(); // GET SUBJECT NAMES (keys)
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
    if (choice != 0 && Questions.ContainsKey(keys[choice - 1]))
    {
        Subj = new Subject(keys[choice - 1], Questions[keys[choice - 1]]);
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
                    exam = new Practical(Subj,10);
                    exam.StartExam();
                    Console.WriteLine("\n");
                    break;
                case 2:
                    exam = new FinalExam(Subj,10);
                    exam.StartExam();
                    Console.WriteLine("\n");
                    break;
                default:
                    exam = null;
                    break;
            }
        }
    }
    i = 1;
} while (choice != 0);
