using Assignment2_StartingPoint.Domain.Entity.State;

namespace Assignment2_StartingPoint.Domain.Entity
{

    // This class implements the Builder design pattern
    public class LoanBuilder
    {
        private int id;
        private Member member;
        private Book book;
        private DateTime dueDate;
        private DateTime loanDate;
        private int numberOfRenewals;
        private DateTime returnDate;

        public LoanBuilder()
        {
            id = -1;
            member = null;
            book = null;
        }

        public Loan Build()
        {
            return new Loan(id, member, book, loanDate, returnDate, LoanStateFactory.Create(numberOfRenewals, dueDate));
        }

        public LoanBuilder WithBook(Book b)
        {
            book = b;
            return this;
        }

        public LoanBuilder WithDueDate(DateTime dt)
        {
            dueDate = dt;
            return this;
        }

        public LoanBuilder WithID(int id)
        {
            this.id = id;
            return this;
        }

        public LoanBuilder WithLoanDate(DateTime dt)
        {
            loanDate = dt;
            return this;
        }

        public LoanBuilder WithMember(Member m)
        {
            member = m;
            return this;
        }

        public LoanBuilder WithNumberOfRenewals(int numRenewals)
        {
            numberOfRenewals = numRenewals;
            return this;
        }

        public LoanBuilder WithReturnDate(DateTime dt)
        {
            returnDate = dt;
            return this;
        }
    }
}
