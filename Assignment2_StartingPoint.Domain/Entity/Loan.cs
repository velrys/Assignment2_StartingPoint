namespace Assignment2_StartingPoint.Domain.Entity
{
    public class Loan : IEntity
    {
        public int ID { get; }
        public Member Member { get; }
        public Book Book { get; }
        public DateTime DueDate
        {
            get
            {
                return state.DueDate;
            }
        }
        public DateTime LoanDate { get; }
        public int NumberOfRenewals
        {
            get
            {
                return state.NumberOfRenewals;
            }
        }
        public DateTime ReturnDate { get; set; }

        private LoanState state;

        public Loan(int ID, Member m, Book b, DateTime loanDate, DateTime returnDate, LoanState state)
        {
            this.ID = ID;
            Member = m;
            Book = b;
            LoanDate = loanDate;
            this.state = state;
            ReturnDate = returnDate;
        }

        public bool Renew()
        {
            state = state.Renew();
            return state.WasRenewed();
        }
    }
}
