namespace Assignment2_StartingPoint.Infrastructure.MySQL_DatabaseGateway
{
    class NullSelector<T> : ISelector<T>
    {
        public T Select()
        {
            throw new Exception("Selection not supported");
        }
    }
}
