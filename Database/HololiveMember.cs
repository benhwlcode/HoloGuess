namespace Database
{
    public class HololiveMember
    {
        public string name { get; set; }
        public int birthday { get; set; }
        public int height { get; set; }
        public int views { get; set; }

        public HololiveMember()
        {

        }

        public HololiveMember(string nameInput, int birthdayInput, int heightInput, int viewsInput)
        {
            name = nameInput;
            birthday = birthdayInput;
            height = heightInput;
            views = viewsInput;
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
            listMembers.Add(new HololiveMember("Gura", 0720, 141, 350));
            listMembers.Add(new HololiveMember("Calli", 0404, 167, 461));
            listMembers.Add(new HololiveMember("Kiara", 0607, 165, 185));
            listMembers.Add(new HololiveMember("Ina", 0520, 157, 126));
            listMembers.Add(new HololiveMember("Ame", 0106, 150, 158));

            listMembers.Add(new HololiveMember("Irys", 0307, 166, 79));

            listMembers.Add(new HololiveMember("Sana", 0610, 169, 15));
            listMembers.Add(new HololiveMember("Fauna", 0321, 164, 82));
            listMembers.Add(new HololiveMember("Kronii", 0314, 168, 58));
            listMembers.Add(new HololiveMember("Mumei", 0804, 156, 68));
            listMembers.Add(new HololiveMember("Baelz", 0229, 149, 77));

            listMembers.Add(new HololiveMember("Sora", 0515, 160, 147));
            listMembers.Add(new HololiveMember("Roboco", 0523, 154, 84));
            listMembers.Add(new HololiveMember("Miko", 0305, 152, 357));
            listMembers.Add(new HololiveMember("Azki", 0701, 158, 59));
            listMembers.Add(new HololiveMember("Suisei", 0322, 160, 572));

        }
    }

}