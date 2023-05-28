﻿using Assignment2_StartingPoint.Domain.Entity;
using System.Collections.Generic;

namespace Assignment2_StartingPoint.Domain
{

    public interface IDatabaseGatewayFacade
    {
        public int AddBook(Book b);

        public int AddMember(Member m);

        public int CreateLoan(Loan loan);

        public int EndLoan(int memberId, int bookId);

        public Book FindBook(int bookId);

        public Loan FindLoan(int memberId, int bookId);

        public Member FindMember(int memberId);

        public List<Book> GetAllBooks();

        public List<Member> GetAllMembers();

        public List<Loan> GetCurrentLoans();

        public void InitialiseDatabase();

        public int RenewLoan(Loan loan);
    }
}
