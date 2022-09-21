using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace POE_ClassLibrary
{
    public class dbManagement
    {
        private SqlConnection sqlConn = new SqlConnection(@"Data Source=20108180vc.database.windows.net;Initial Catalog=PROG6212POE;User ID=James;Password=jm!20108180;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        // Constructor Method
        public dbManagement()
        {
        }

        // This method creates the SQL Connection that is going to be used to connect to the database
        public SqlConnection GetDatabaseConnection()
        {
            // this checks if the connection is NOT open
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }

            return sqlConn;
        }

        // This method returns a table that can be used to get the correct SQL statements
        public DataTable GetDataTable(string sSQL)
        {
            SqlConnection sqlConn = GetDatabaseConnection(); // getting the db connection
            DataTable sqlTbl = new DataTable(); // creating a table for the adapter to use

            SqlDataAdapter adapter = new SqlDataAdapter(sSQL, sqlConn);
            adapter.Fill(sqlTbl);

            return sqlTbl;
        }

        // This method Executes the SQL it has been given
        public void ExecuteSQLStatement(string sSQL)
        {
            SqlConnection sqlConn = GetDatabaseConnection();
            SqlCommand sqlCom = new SqlCommand(sSQL, sqlConn);

            sqlCom.ExecuteNonQuery();
        }

        //This method closes the connection string after use
        public void CloseDatabaseConnection()
        {
            string sConnection = @"Data Source=20108180vc.database.windows.net;Initial Catalog=cdlv6212POE20108180;User ID=James;Password=jm!20108180;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection sqlConn = new SqlConnection(sConnection);

            // if it is NOT already closed than close it
            if (sqlConn.State != ConnectionState.Closed)
                sqlConn.Close();
        }
    }
}