using System;
using System.Globalization;

namespace IntermediateCourseDbConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sqlDbCommand = new DbCommand(new SqlConnection("Key to SQL"), "CREATE DATABASE Music;");
            sqlDbCommand.Execute();
        }
    }
}
