using Assignment2_StartingPoint.Domain.DTOs;
using CommandLineUI.Commands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;

namespace Assignment2_StartingPoint.Client
{
    public class HttpSever : HttpClient
    {
        public HttpSever() : base()
        {
            this.BaseAddress = new Uri(ConfigClient.UrlServer);
        }

        public MemberDTO_List ViewAllMembers()
        {
            return this.GetFromJsonAsync<MemberDTO_List>("Member/All").Result;
        }

        public BookDTO_List ViewAllBooks()
        {
            return this.GetFromJsonAsync<BookDTO_List>("Book/All").Result;
        }

        public Dictionary<string, string> Borrowbook(int memberID, int bookID)
        {
            return BookAction("Loan/Borrow", memberID, bookID);
        }

        public Dictionary<string, string> Returnbook(int memberID, int bookID)
        {
            return BookAction("Loan/Return", memberID, bookID);
        }

        public Dictionary<string, string> RenewLoan(int memberID, int bookID)
        {
            return BookAction("Loan/Renew", memberID, bookID);
        }

        public List<MemberDTO> ViewMembers()
        {
            return this.GetFromJsonAsync<MemberDTO_List>("Member/All").Result.List;
        }

        public List<BookDTO> ViewBooks()
        {
            return this.GetFromJsonAsync<BookDTO_List>("Book/All").Result.List;
        }

        public List<LoanViewtDTO> ViewCurrentLoans()
        {
            return  this.GetFromJsonAsync<List<LoanViewtDTO>>("Loan/Current").Result;            
        }

        private Dictionary<string, string> BookAction(string request, int memberID, int bookID)
        {
            var result = this.PostAsJsonAsync(request, new OperationBook()
            {
                BookID = bookID,
                MemberID = memberID
            }).Result;

            if (result.IsSuccessStatusCode)
            {
                return result.Content.ReadFromJsonAsync<Dictionary<string, string>>().Result;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
