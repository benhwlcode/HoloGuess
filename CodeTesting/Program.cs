using Database;

namespace CodeTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HololiveMember> listChoices = new List<HololiveMember>();

            HololiveMember userDecision = new HololiveMember();

            HololiveMember multipleChoice1 = new HololiveMember();
            HololiveMember multipleChoice2 = new HololiveMember();
            HololiveMember multipleChoice3 = new HololiveMember();
            HololiveMember multipleChoice4 = new HololiveMember();

            Shuffler shuffler = new Shuffler();
            shuffler.Shuffle(MemberList.listMembers);
            shuffler.Shuffle(QuestionList.listQuestions);

            multipleChoice1 = MemberList.listMembers[0];
            multipleChoice2 = MemberList.listMembers[1];
            multipleChoice3 = MemberList.listMembers[2];
            multipleChoice4 = MemberList.listMembers[3];

            listChoices.Add(multipleChoice1);
            listChoices.Add(multipleChoice2);
            listChoices.Add(multipleChoice3);
            listChoices.Add(multipleChoice4);

            Console.WriteLine(QuestionList.listQuestions[0].text);
            Console.WriteLine("1) {0}, 2) {1}, 3) {2}, or 4) {3}?",
                multipleChoice1.name, multipleChoice2.name,
                multipleChoice3.name, multipleChoice4.name);

            Console.WriteLine("{0}, {1}, {2}, {3}",
                multipleChoice1.birthday, multipleChoice2.birthday,
                multipleChoice3.birthday, multipleChoice4.birthday);

            Console.WriteLine("{0}, {1}, {2}, {3}",
                multipleChoice1.height, multipleChoice2.height,
                multipleChoice3.height, multipleChoice4.height);

            QuestionList.listQuestions[0].method(listChoices);

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                userDecision = multipleChoice1;
            }
            else if (userChoice == "2")
            {
                userDecision = multipleChoice2;
            }
            else if (userChoice == "3")
            {
                userDecision = multipleChoice3;
            }
            else if (userChoice == "4")
            {
                userDecision = multipleChoice4;
            }

            Console.Write("You chose {0}, and your answer is...", userChoice);

            if (userDecision == listChoices[0])
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }


            Console.ReadLine();
        }
    }
}