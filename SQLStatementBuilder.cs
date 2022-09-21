using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace POE_ClassLibrary
{
    public class SQLStatementBuilder
    {
        private string sSQL;
        private string sTable;
        private string sField;

        public SQLStatementBuilder(string sSQL)
        {
            this.SSQL = sSQL;
        }

        public string SSQL { get => sSQL; set => sSQL = value; }
        public string STable { get => sTable; set => sTable = value; }
        public string SField { get => sField; set => sField = value; }

        // This method adds a new record to the database depending on what how long the list that is given to it is
        public string AddSql(List<string> arrValues)
        {
            switch (arrValues.Count)
            {
                case 7:
                    {
                        // MODULES add
                        sTable = "MODULES";
                        sSQL = "INSERT INTO " + sTable +
                            " ([ModuleCode], [ModuleName], [NoCredits], [ClassHours], [NoWeeks], [StartDate], [UserID]) VALUES ("
                            + "\'" + arrValues[0] + "\', "
                            + "\'" + arrValues[1] + "\', "
                            + arrValues[2] + ", "
                            + arrValues[3] + ", "
                            + arrValues[4] + ", "
                            + "\'" + arrValues[5] + "\', "
                            + arrValues[6]
                            + ")";
                        break;
                    }
                case 3:
                    {
                        // MODULES_WEEK add
                        sTable = "MODULES_WEEK";
                        sSQL = "INSERT INTO " + sTable +
                            " ([StartDate], [HoursLeft], [ModuleID]) VALUES (" 
                            + "\'" + arrValues[0] + "\', "
                            + arrValues[1] + ", "
                            + arrValues[2]
                            + ")";
                        break;
                    }
                case 6:
                    {
                        // USERS add
                        sTable = "USERS";
                        sSQL = "INSERT INTO " + sTable +
                            " ([DateOfBirth], [DegreeName], [Username], [Password], [FirstName], [Surname]) VALUES ("
                            + "\'" + arrValues[0] + "\', "
                            + "\'" + arrValues[1] + "\', "
                            + "\'" + arrValues[2] + "\', "
                            + "\'" + arrValues[3] + "\', "
                            + "\'" + arrValues[4] + "\', "
                            + "\'" + arrValues[5] + "\'"
                            + ")";
                        break;
                    }
            }

            return sSQL;
        }

        // This method updates the only table that needs to be updated which is the MODULES_WEEK table
        public string UpdateSql(int iHoursLeft, int iWeekID)
        {
            sTable = "MODULES_WEEK"; // this is the only table that will be "updated"
            sSQL = "UPDATE " + sTable + " SET [HoursLeft] = " + iHoursLeft.ToString() + " WHERE [WeekID] = " + iWeekID.ToString();
            return sSQL;
        }

        public string DeleteSql(string sCondition)
        {
            sSQL = "DELETE FROM " + sTable + " WHERE " + sCondition;
            return sSQL;
        }
        public string DisplaySql()
        {
            sSQL = "SELECT * FROM " + sTable;
            return sSQL;
        }

    }
}
