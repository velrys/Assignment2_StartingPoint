using System.Collections.Generic;

namespace Assignment2_StartingPoint.Domain.DTOs
{
    [Serializable]
    public class BookDTO_List : IDto
    {
        public List<BookDTO> List { get; }

        public BookDTO_List(List<BookDTO> list)
        {
            List = list;
        }
    }
}
