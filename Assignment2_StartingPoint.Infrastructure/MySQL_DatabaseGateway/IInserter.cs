namespace Assignment2_StartingPoint.Infrastructure.MySQL_DatabaseGateway
{

    // This interface illustrates the Interface Segregation Principle
    interface IInserter<T>
    {
        public int Insert(T itemToInsert);
    }
}
