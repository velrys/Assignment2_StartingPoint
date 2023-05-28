namespace Assignment2_StartingPoint.Domain.DTOs
{
    [Serializable]
    public class BookDTO : IDto
    {
        public int Id { get; }
        public string Author { get; }
        public string ISBN { get; }
        public string Title { get; }
        public string State { get; }

        public BookDTO(int id, string author, string isbn, string title, string state)
        {
            Id = id;
            Author = author;
            ISBN = isbn;
            Title = title;
            State = state;
        }
    }
}
