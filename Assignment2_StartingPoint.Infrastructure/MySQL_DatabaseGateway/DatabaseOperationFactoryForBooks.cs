using Assignment2_StartingPoint.Domain.Entity;

namespace Assignment2_StartingPoint.Infrastructure.MySQL_DatabaseGateway
{
    class DatabaseOperationFactoryForBooks
    {
        public const int SELECT_ALL = 1;
        public const int SELECT_BY_ID = 2;

        public DatabaseInserter<Book> CreateInserter()
        {
            return new InsertBook();
        }

        public ISelector<List<Book>> CreateSelector(int typeOfSelection)
        {
            if (typeOfSelection == SELECT_ALL)
            {
                return new GetAllBooks();
            }
            return new NullSelector<List<Book>>();
        }

        public ISelector<Book> CreateSelector(int typeOfSelection, int i)
        {
            switch (typeOfSelection)
            {
                case SELECT_BY_ID:
                    return new FindBookById(i);
                default:
                    return new NullSelector<Book>();
            }
        }
    }
}
