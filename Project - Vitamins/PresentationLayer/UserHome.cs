using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void ChooseSymptomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseSymptom newForm = new ChooseSymptom();
            newForm.ShowDialog();
        }

        private void VitaminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVitamins newForm = new ShowVitamins();
            newForm.ShowDialog();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Home newForm = new Home();
            newForm.ShowDialog();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {

        }
    }
}
