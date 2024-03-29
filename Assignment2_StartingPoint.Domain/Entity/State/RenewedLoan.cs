﻿using Assignment2_StartingPoint.Domain.Entity;

namespace Assignment2_StartingPoint.Domain.Entity.State
{
    public class RenewedLoan : LoanRenewalState
    {
        public RenewedLoan(int numberOfRenewals, DateTime dueDate) : base(numberOfRenewals, dueDate)
        {
        }

        public override LoanState Renew()
        {
            return LoanStateFactory.Create(NumberOfRenewals + 1, DueDate.AddDays(14));
        }

        public override bool WasRenewed()
        {
            return true;
        }
    }
}