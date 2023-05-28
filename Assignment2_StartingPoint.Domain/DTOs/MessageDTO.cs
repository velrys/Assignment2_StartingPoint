namespace Assignment2_StartingPoint.Domain.DTOs
{
    [Serializable]
    public class MessageDTO : IDto
    {
        public string Message { get; }

        public MessageDTO(string msg)
        {
            Message = msg;
        }
        public MessageDTO()
        {
            
        }
    }
}
