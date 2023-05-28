using System.Collections.Generic;

namespace Assignment2_StartingPoint.Domain.DTOs
{
    [Serializable]
    public class MemberDTO_List : IDto
    {
        public List<MemberDTO> List { get; }

        public MemberDTO_List(List<MemberDTO> list)
        {
            List = list;
        }
    }
}
