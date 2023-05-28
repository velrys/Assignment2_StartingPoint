using Assignment2_StartingPoint.Domain.Entity;
using MySql.Data.MySqlClient;

namespace Assignment2_StartingPoint.Infrastructure.MySQL_DatabaseGateway
{
    class InsertMember : DatabaseInserter<Member>
    {

        protected override string GetSQL()
        {
            return
                "INSERT INTO SDAM_Member (Name) " +
                "VALUES (@member_name)";
        }

        protected override int DoInsert(MySqlCommand command, Member memberToInsert)
        {
            command.Parameters.AddWithValue("@member_name", memberToInsert.Name);
            command.Prepare();
            int numRowsAffected = command.ExecuteNonQuery();

            if (numRowsAffected != 1)
            {
                throw new Exception("ERROR: member not inserted");
            }
            return numRowsAffected;
        }
    }
}
