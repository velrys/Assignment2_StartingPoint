﻿namespace Assignment2_StartingPoint.Domain.Entity
{
    public class Book : IEntity
    {
        public int ID { get; }
        public string Author { get; }
        public string ISBN { get; }
        public string Title { get; }

        private BookState state;
        public string State { get { return state.ToString(); } }

        public Book(int id, string author, string title, string isbn, BookState state)
        {
            ID = id;
            Author = author;
            ISBN = isbn;
            Title = title;
            this.state = state;
        }

        public override string ToString()
        {
            return Title;
        }

        public bool Borrow()
        {
            bool canBorrow = state.CanBorrow();
            state = state.Borrow();
            return canBorrow;
        }

        public bool Return()
        {
            bool canReturn = state.CanReturn();
            state = state.Return();
            return canReturn;
        }
    }
}
