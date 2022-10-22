using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_FINAL.Classes.Task_1_Classes
{
    /// <summary>
    /// This class handles all of the messages so that code does not need to be repeated
    /// </summary>
    internal class Messages
    {
        /// <summary>
        /// This is the message that displays on the exit button and if they select is yes then they exit
        /// </summary>
        public void ExitMessage()
        {
            MessageBoxButtons bb = MessageBoxButtons.YesNo;
            MessageBoxIcon bi = MessageBoxIcon.Exclamation;
            MessageBoxDefaultButton db = MessageBoxDefaultButton.Button2; // sets the default button to "No"
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Application", bb, bi, db);

            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// This method receives a string and puts it on a standardised error message
        /// </summary>
        /// <param name="sError"></param>
        public void ErrorMessage(string sError)
        {
            MessageBoxButtons bb = MessageBoxButtons.OK;
            MessageBoxIcon bi = MessageBoxIcon.Error;
            MessageBoxDefaultButton db = MessageBoxDefaultButton.Button1; // sets the default button to "OK"

            MessageBox.Show(sError, "ERROR", bb, bi, db);

        }

        /// <summary>
        /// This method receives a string and puts it on a standardised success message 
        /// </summary>
        /// <param name="v"></param>
        internal void SuccessMessage(string v)
        {
            MessageBoxButtons bb = MessageBoxButtons.OK;
            MessageBoxIcon bi = MessageBoxIcon.Asterisk;
            MessageBoxDefaultButton db = MessageBoxDefaultButton.Button1; // sets the default button to "OK"

            MessageBox.Show(v, "Success!", bb, bi, db);
        }
    }  
}
