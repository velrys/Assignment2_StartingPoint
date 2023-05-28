namespace Assignment2_StartingPoint.Domain.Entity
{
    public class MemberBuilder
    {
        private int id;
        private string name;

        public MemberBuilder()
        {
            id = -1;
            name = "";
        }

        public Member Build()
        {
            return new Member(id, name);
        }

        public MemberBuilder WithId(int id)
        {
            this.id = id;
            return this;
        }

        public MemberBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }
    }
}
