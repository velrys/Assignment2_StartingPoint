namespace Assignment2_StartingPoint.Infrastructure.MySQL_DatabaseGateway
{
    class NullUpdater<T> : IUpdater<T>
    {
        public int Update(T itemToUpdate)
        {
            throw new Exception("Update operation not supported");
        }
    }
}
