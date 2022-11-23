using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseDbConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public bool IsRunning { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(String connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException("connectionString");
            }

            ConnectionString = connectionString;
            Console.WriteLine(ConnectionString);
        }

        public abstract bool OpenConnection();

        public abstract bool CloseConnection();
    }
}
