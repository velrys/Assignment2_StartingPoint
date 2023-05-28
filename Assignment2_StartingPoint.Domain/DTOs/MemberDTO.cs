namespace Assignment2_StartingPoint.Domain.DTOs
{
    [Serializable]
    public class MemberDTO : IDto
    {
        public int ID { get; }
        public string Name { get; }

        public MemberDTO(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
