
using System.Text.Json.Serialization;

namespace Assignment2_StartingPoint.Domain.DTOs
{
    public class LoanViewtDTO : IDto
    {        
        public int Id { get; set; }        
        public string Member { get; set; }
        public string Book { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }        
        public int NumberOfRenewals { get; set; }

        public LoanViewtDTO()
        {
                
        }

        public LoanViewtDTO(LoanDTO loanDTO)
        {
            Id = loanDTO.ID;
            Member = loanDTO.Member.Name;
            Book = loanDTO.Book.Title;
            LoanDate = loanDTO.LoanDate;
            DueDate = loanDTO.DueDate;
            ReturnDate = loanDTO.ReturnDate;
            NumberOfRenewals = loanDTO.NumberOfRenewals;            
        }
    }
}
