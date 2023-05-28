namespace Assignment2_StartingPoint.Domain.Entity
{
    public class Member : IEntity
    {
        public int ID { get; }
        public string Name { get; }

        public Member(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return ID + ": " + Name;
        }
    }
}
