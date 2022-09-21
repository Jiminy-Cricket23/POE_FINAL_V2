using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace POE_ClassLibrary
{
    /// <summary>
    /// Database SQL builder 
    /// </summary>
    public class SQLStatementBuilder
    {

        public SQLStatementBuilder()
        {
        
        }

       
      
        /// <summary>
        /// This method adds a new record to the database depending on what how long the list that is given to it is
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <param name="FirstName"></param>
        /// <param name="Surname"></param>
        /// <returns></returns>
        public string AddSql(int iOptions,Dictionary<string, string> d)
        {
            /* OPTIONS
             * 0 - Register a new user
             * 1 - Unlock a new Theme
             * 2 - NOT IMPLEMENTED adding Salt
             */
            // This user will be created when registering
            string sSQL = "";
            if (iOptions == 0)
            {
                sSQL = "INSERT INTO [dbo].[User]"
                    + " ([Username], [Password], [FirstName], [Surname], [Points], [ThemeID]) VALUES ("
                    + "\'" + d["Username"] + "\', "
                    + "\'" + d["Password"] + "\', "
                    + "\'" + d["FirstName"] + "\', "
                    + "\'" + d["Surname"] + "\', "
                    + "0, "
                    + "1"
                    //+ d["SaltID"]
                    + ")";
            }
            else if (iOptions == 1)
            {
                sSQL = "INSERT INTO [dbo].[UserThemes]"
                     + " ([UserID], [ThemeID]) VALUES ("
                     + "\'" + d["UserID"] + "\', "
                     + "\'" + d["ThemeID"] + "\'"
                     + ")";
            } /*
            else
            {
                sSQL = "INSERT INTO [dbo].[Salt]"
                     + " ([SaltValue]) VALUES ("
                     + "\'" + d["SaltValue"] + "\'"
                     + ")";
            } */
           
            return sSQL;
        }

        /// <summary>
        /// This method updates the only table that needs to be updated which is the MODULES_WEEK table
        /// </summary>
        /// <param name="iHoursLeft"></param>
        /// <param name="iWeekID"></param>
        /// <returns></returns>
        public string UpdateSql(int iOptions, int iPoints, string sID, string sThemeID)
        {
            /* OPTIONS
             * 0 - points
             * 1 - Selected Theme
             * FUTURE
             * 2 - Name
             * 3 - Surname
             * 4 - Username
             * 5 - Password
             */

            string sSQL = "";
            if (iOptions == 0)
            {
                dbManagement db = new dbManagement();
                Dictionary<string, string> d = new Dictionary<string, string>();
                d.Add("UserID", sID);
                int newPoints = iPoints + int.Parse(db.GetValue(4, d)[0]);
                sSQL = "UPDATE [dbo].[User] SET [Points] = " + newPoints.ToString() + " WHERE [UserID] = " + sID;
            }
            if (iOptions == 1)
            {                
                sSQL = "UPDATE [dbo].[User] SET [ThemeID] = " + sThemeID + " WHERE [UserID] = " + sID;

            } /* FOR FUTURE DEVELOPMENT
            if (iOptions == 2)
            if (iOptions == 3)
            if (iOptions == 4)
            if (iOptions == 5) */
            
            return sSQL;
        }/* THESE ARE NOT NEEDED FOR NOW
        /// <summary>
        /// Creates the delete string
        /// </summary>
        /// <param name="sCondition"></param>
        /// <returns></returns>
        public string DeleteSql(string sCondition)
        {
            sSQL = "DELETE FROM " + sTable + " WHERE " + sCondition;
            return sSQL;
        }
        /// <summary>
        /// Creates the display SQL
        /// </summary>
        /// <returns></returns>
        public string DisplaySql()
        {
            sSQL = "SELECT * FROM " + sTable;
            return sSQL;
        } */

    }
}
