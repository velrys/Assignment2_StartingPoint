namespace Assignment2_StartingPoint.Domain.Entity
{
    public interface LoanState
    {
        DateTime DueDate { get; }

        int NumberOfRenewals { get; }

        LoanState Renew();

        bool WasRenewed();
    }
}