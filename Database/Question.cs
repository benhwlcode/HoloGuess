using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Question
    {
        public string text { get; set; }
        public Func<List<HololiveMember>, List<HololiveMember>> method { get; set; }

        public Question()
        {

        }

        public Question(string textInput, Func<List<HololiveMember>, List<HololiveMember>> methodInput)
        {
            text = textInput;
            method = methodInput;
        }
    }

    public class QuestionList
    {
        public static List<Question> listQuestions = new List<Question>();

        static QuestionList()
        {
            PopulateQuestionList();
        }

        private static void PopulateQuestionList()
        {
            listQuestions.Add(new Question("Who has the latest birthday?", DescendBirthday));
            listQuestions.Add(new Question("Who has the earliest birthday?", AscendBirthday));
            listQuestions.Add(new Question("Who is the tallest?", DescendHeight));
            listQuestions.Add(new Question("Who is the shortest", AscendHeight));
        }

        public static List<HololiveMember> DescendBirthday(List<HololiveMember> choicesList)
        {
            choicesList.Sort((x, y) => y.birthday - x.birthday);
            return choicesList;
        }

        public static List<HololiveMember> AscendBirthday(List<HololiveMember> choicesList)
        {
            choicesList.Sort((x, y) => x.birthday - y.birthday);
            return choicesList;
        }

        public static List<HololiveMember> DescendHeight(List<HololiveMember> choicesList)
        {
            choicesList.Sort((x, y) => y.height - x.height);
            return choicesList;
        }

        public static List<HololiveMember> AscendHeight(List<HololiveMember> choicesList)
        {
            choicesList.Sort((x, y) => x.height - y.height);
            return choicesList;
        }


    }


}
