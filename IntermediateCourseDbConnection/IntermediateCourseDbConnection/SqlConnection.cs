using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseDbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }

        public override bool OpenConnection()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("SQL connection already established");
            }
            IsRunning = true;
            Console.WriteLine("Connection opened for SQL DB");
            return IsRunning;
        }

        public override bool CloseConnection()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("SQL connection is already closed");
            }
            IsRunning = false;
            Console.WriteLine("Connection closed for SQL DB");
            return IsRunning;
        }
    }
}
