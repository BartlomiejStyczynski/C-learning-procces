//To access a database, we need to open a connection to it first and close it once our job is done.
//Connecting to a database depends on the type of the target database and the database
//management system(DBMS). For example, connecting to a SQL Server database is different
//from connecting to an Oracle database.But both these connections have a few things in
//common:
//• They have a connection string
//• They can be opened
//• They can be closed
//• They may have a timeout attribute(so if the connection could not be opened within the
//timeout, an exception will be thrown).

using System;

namespace POLYMORPHISM___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {


            var newConnection = new DbCommand();

            newConnection.Execute("123123", new SqlConnection());


        }
 
    }

}

