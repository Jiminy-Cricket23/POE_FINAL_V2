using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_FINAL.Classes.Task_1_Classes
{
    internal class Messages
    {
        public void ExitMessage()
        {
            MessageBoxButtons bb = MessageBoxButtons.YesNo;
            MessageBoxIcon bi = MessageBoxIcon.Exclamation;
            MessageBoxDefaultButton db = MessageBoxDefaultButton.Button1; // sets the default button to "yes"
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Application", bb, bi, db);

            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        public void ErrorMessage(string sError)
        {
            MessageBoxButtons bb = MessageBoxButtons.OK;
            MessageBoxIcon bi = MessageBoxIcon.Error;
            MessageBoxDefaultButton db = MessageBoxDefaultButton.Button1; // sets the default button to "yes"

            MessageBox.Show(sError, "ERROR", bb, bi, db);

        }

        internal void Success(string v)
        {
            MessageBoxButtons bb = MessageBoxButtons.OK;
            MessageBoxIcon bi = MessageBoxIcon.Asterisk;
            MessageBoxDefaultButton db = MessageBoxDefaultButton.Button1; // sets the default button to "yes"

            MessageBox.Show(v, "ERROR", bb, bi, db);
        }
    }  
}
