namespace Database
{
    public class HololiveMember
    {
        public string name { get; set; }
        public int birthday { get; set; }
        public int height { get; set; }

        public HololiveMember()
        {

        }

        public HololiveMember(string nameInput, int birthdayInput, int heightInput)
        {
            name = nameInput;
            birthday = birthdayInput;
            height = heightInput;
        }
    }

    public class MemberList
    {
        public static List<HololiveMember> listMembers = new List<HololiveMember>();

        static MemberList()
        {
            PopulateMemberList();
        }

        private static void PopulateMemberList()
        {
            listMembers.Add(new HololiveMember("Gura", 0720, 141));
            listMembers.Add(new HololiveMember("Calli", 0404, 167));
            listMembers.Add(new HololiveMember("Kiara", 0607, 165));
            listMembers.Add(new HololiveMember("Ina", 0520, 157));
            listMembers.Add(new HololiveMember("Ame", 0106, 150));

            listMembers.Add(new HololiveMember("Irys", 0307, 166));

            listMembers.Add(new HololiveMember("Sana", 0610, 169));
            listMembers.Add(new HololiveMember("Fauna", 0321, 164));
            listMembers.Add(new HololiveMember("Kronii", 0314, 168));
            listMembers.Add(new HololiveMember("Mumei", 0804, 156));
            listMembers.Add(new HololiveMember("Baelz", 0229, 149));
        }
    }

}