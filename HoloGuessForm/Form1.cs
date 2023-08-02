using Database;

namespace HoloGuessForm
{
    public partial class Form1 : Form
    {
        HololiveMember userChoice = new HololiveMember();

        HololiveMember multiChoice1 = new HololiveMember();
        HololiveMember multiChoice2 = new HololiveMember();
        HololiveMember multiChoice3 = new HololiveMember();
        HololiveMember multiChoice4 = new HololiveMember();
        Question currentQuestion = new Question();

        List<HololiveMember> listChoices = new List<HololiveMember>();
        int correct;
        int wrong;

        public Form1()
        {
            InitializeComponent();
            correct = 0;
            wrong = 0;

            tbQuestion.Text = "Welcome to the Hololive Guessing Game";


            lblCorrect.Text = correct.ToString();
            lblWrong.Text = wrong.ToString();

            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnChoice1.Enabled = true;
            btnChoice2.Enabled = true;
            btnChoice3.Enabled = true;
            btnChoice4.Enabled = true;


            EmptyList(listChoices, multiChoice1, multiChoice2, multiChoice3, multiChoice4);

            DetermineQuestion(out currentQuestion);

            tbQuestion.Text = currentQuestion.text;

            AssignChoices(out multiChoice1, out multiChoice2,
                out multiChoice3, out multiChoice4);

            PopulateList(listChoices,
                multiChoice1, multiChoice2, multiChoice3, multiChoice4);

            btnChoice1.Text = multiChoice1.name;
            btnChoice2.Text = multiChoice2.name;
            btnChoice3.Text = multiChoice3.name;
            btnChoice4.Text = multiChoice4.name;

            btnNext.Enabled = false;


        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {
            AssignUserDecision(out userChoice, multiChoice1);
            currentQuestion.method(listChoices);
            if (userChoice.name == listChoices[0].name)
            {
                tbResult.Text = "Yay! You are right.";
                lblCorrect.Text = (++correct).ToString();
            }
            else
            {
                tbResult.Text = "Nay! You are wrong.";
                lblWrong.Text = (++wrong).ToString();
            }

            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;
            btnNext.Enabled = true;
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            AssignUserDecision(out userChoice, multiChoice2);
            currentQuestion.method(listChoices);
            if (userChoice.name == listChoices[0].name)
            {
                tbResult.Text = "Yay! You are right.";
                lblCorrect.Text = (++correct).ToString();
            }
            else
            {
                tbResult.Text = "Nay! You are wrong.";
                lblWrong.Text = (++wrong).ToString();
            }

            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;
            btnNext.Enabled = true;

        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            AssignUserDecision(out userChoice, multiChoice3);
            currentQuestion.method(listChoices);
            if (userChoice.name == listChoices[0].name)
            {
                tbResult.Text = "Yay! You are right.";
                lblCorrect.Text = (++correct).ToString();
            }
            else
            {
                tbResult.Text = "Nay! You are wrong.";
                lblWrong.Text = (++wrong).ToString();
            }

            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;
            btnNext.Enabled = true;

        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {
            AssignUserDecision(out userChoice, multiChoice4);
            currentQuestion.method(listChoices);
            if (userChoice.name == listChoices[0].name)
            {
                tbResult.Text = "Yay! You are right.";
                lblCorrect.Text = (++correct).ToString();
            }
            else
            {
                tbResult.Text = "Nay! You are wrong.";
                lblWrong.Text = (++wrong).ToString();
            }

            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;
            btnNext.Enabled = true;
        }

        private static HololiveMember AssignChoices(
            out HololiveMember choice1, out HololiveMember choice2,
            out HololiveMember choice3, out HololiveMember choice4)
        {
            Shuffler shuffler = new Shuffler();
            shuffler.Shuffle(MemberList.listMembers);
            shuffler.Shuffle(QuestionList.listQuestions);

            choice1 = MemberList.listMembers[0];
            choice2 = MemberList.listMembers[1];
            choice3 = MemberList.listMembers[2];
            choice4 = MemberList.listMembers[3];

            return choice1;
            return choice2;
            return choice3;
            return choice4;
        }

        private static Question DetermineQuestion(out Question question)
        {
            Shuffler shuffler = new Shuffler();
            shuffler.Shuffle(QuestionList.listQuestions);
            question = QuestionList.listQuestions[0];

            return question;
        }

        private static List<HololiveMember> PopulateList(List<HololiveMember> choicesList,
            HololiveMember choice1, HololiveMember choice2,
            HololiveMember choice3, HololiveMember choice4)
        {
            choicesList.Add(choice1);
            choicesList.Add(choice2);
            choicesList.Add(choice3);
            choicesList.Add(choice4);
            return choicesList;
        }

        private static List<HololiveMember> EmptyList(List<HololiveMember> choicesList,
            HololiveMember choice1, HololiveMember choice2,
            HololiveMember choice3, HololiveMember choice4)
        {
            choicesList.Remove(choice1);
            choicesList.Remove(choice2);
            choicesList.Remove(choice3);
            choicesList.Remove(choice4);
            return choicesList;
        }

        private static HololiveMember AssignUserDecision(
            out HololiveMember user, HololiveMember decision)
        {
            user = decision;
            return user;
        }

        private static void DetermineAnswer(List<HololiveMember> choicesList)
        {
            QuestionList.listQuestions[0].method(choicesList);
        }


    }
}