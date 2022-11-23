using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseDbConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override bool OpenConnection()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Oracle connection already established");
            }

            IsRunning = true;
            Console.WriteLine("Connection opened for Oracle DB");
            return IsRunning;
        }

        public override bool CloseConnection()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("Oracle connection is already closed");
            }
            IsRunning = false;
            Console.WriteLine("Connection closed for Oracle DB");
            return IsRunning;
        }
    }
}
