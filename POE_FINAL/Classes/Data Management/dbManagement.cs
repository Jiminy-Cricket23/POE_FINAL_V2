using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace POE_ClassLibrary
{
    /// <summary>
    /// Database Management Class
    /// </summary>
    public class dbManagement
    {
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\mitchellwp\OneDrive - Cape Peninsula University of Technology\Documents\James\PROG7312\POE\Task 1\POE_FINAL\POE_FINAL\Classes\Data Management\dbGame.mdf";Integrated Security=True
        //private SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "\"\"" + @"C:\Users\James\Documents\Varsity College\Year 3\Semester 2\PROG7312\POE\Task 1\POE_FINAL\POE_FINAL\Classes\Data Management\dbGame.mdf" + "\"\"" + @"; Integrated Security=True");
        private SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf; Integrated Security=True");
        // Constructor Method
        public dbManagement()
        {
        }

        /// <summary>
        /// This method creates the SQL Connection that is going to be used to connect to the database
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetDatabaseConnection()
        {
            // this checks if the connection is NOT open
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();
            
            return sqlConn;
        }

        /// <summary>
        /// This method returns a table that can be used to get the correct SQL statements
        /// </summary>
        /// <param name="sSQL"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string sSQL)
        {
            SqlConnection sqlConn = GetDatabaseConnection(); // getting the db connection
            DataTable sqlTbl = new DataTable(); // creating a table for the adapter to use

            SqlDataAdapter adapter = new SqlDataAdapter(sSQL, sqlConn);
            adapter.Fill(sqlTbl);

            return sqlTbl;
        }

        /// <summary>
        /// This method Executes the SQL it has been given
        /// </summary>
        /// <param name="sSQL"></param>
        public void ExecuteSQLStatement(string sSQL)
        {
            SqlConnection sqlConn = GetDatabaseConnection();
            SqlCommand sqlCom = new SqlCommand(sSQL, sqlConn);

            sqlCom.ExecuteNonQuery();
            //MessageBox.Show("Successful");
        }

        /// <summary>
        /// This method closes the connection string after use
        /// </summary>
        public void CloseDatabaseConnection()
        {
            // if it is NOT already closed than close it
            if (sqlConn.State != ConnectionState.Closed)
                sqlConn.Close();
        }

        // TODO: GetValue from the database
        //https://stackoverflow.com/questions/16565035/how-do-i-get-values-from-a-sql-database-into-textboxes-using-c
        public List<string> GetValue(int iOptions, Dictionary<string, string> d)
        {
            /* OPTIONS
             * 0 - Login
             * 1 - NOT IMPLEMENTED Get the Salt
             * 2 - NOT IMPLEMENTED Get Last ID of Salt
             * 3 - Theme Colour Numbers
             * 4 - Get Points
             */
            List<string> sOutput = new List<string>();
            string selectSql = "";
            List<string> sField = new List<string>();
            if (iOptions == 0)
            {
                selectSql = @"SELECT * FROM [dbo].[User] WHERE [Username] = '" + d["Username"] + "' AND [Password] = '" + d["Password"] + "'";
                sField.Add("UserID");
            }
            else if (iOptions == 3)
            {
                selectSql = @"SELECT * FROM [dbo].[Themes] WHERE [ThemeID] = '" + d["ThemeID"] + "'";
                sField.Add("HeaderR");
                sField.Add("HeaderG");
                sField.Add("HeaderB");
                sField.Add("BodygroundR");
                sField.Add("BodygroundG");
                sField.Add("BodygroundB");
                sField.Add("isDarkMode");
                sField.Add("ThemeName");
            }
            else if (iOptions == 4)
            {
                selectSql = @"SELECT * FROM [dbo].[User] WHERE [UserID] = '" + d["UserID"] + "'";
                sField.Add("Points");
            }
            

            try
            {
                if (sqlConn.State != ConnectionState.Open)
                    sqlConn.Open();
                SqlCommand sqlCom = new SqlCommand(selectSql, sqlConn);
                //SqlDataReader reader = sqlCom.ExecuteReader();

                using (SqlDataReader read = sqlCom.ExecuteReader())
                {
                    while (read.Read())
                    {
                        for (int i = 0; i < sField.Count(); i++)
                        {
                            sOutput.Add(read[sField[i]].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            return sOutput;
        }
    }
}