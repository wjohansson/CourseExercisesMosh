using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseDbConnection
{
    internal class DbCommand
    {
        public DbConnection DbConnection { get; set; }
        private string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null || String.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException();
            }
            DbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            DbConnection.OpenConnection();
    
            Console.WriteLine("Added instruction to database: " + _instruction);

            DbConnection.CloseConnection();
        }
    }
}
