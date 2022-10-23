using POE_FINAL.Classes.Task_1_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_FINAL
{
    public partial class frmFindingAreas : Form
    {
        private Messages ms = new Messages();
        private Dictionary<string, string> dicCategories = new Dictionary<string,string>(){
            {"000", "General Knowledge"},
            {"100", "Philosophy & Psychology"},
            {"200", "Religion"},
            {"300", "Social Sciences"},
            {"400", "Languages"},
            {"500", "Science"},
            {"600", "Technology"},
            {"700", "Arts & Recreation"},
            {"800", "Literature"},
            {"900", "History & Geography"}
        };  
        public frmFindingAreas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The red close button on the top right of the form to close it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            ms.ExitMessage();
        }

        /// <summary>
        /// This button returns to the main home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// The Dictionary loads as the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFindingAreas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
