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
    public partial class ShowVitamins : Form
    {
        public ShowVitamins()
        {
            InitializeComponent();
        }

        private void HomeSymptomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHome newForm = new UserHome();
            newForm.ShowDialog();
        }

        private void ChooseSymptomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseSymptom newForm = new ChooseSymptom();
            newForm.ShowDialog();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.ShowDialog();
        }

        private void ShowVitamins_Load(object sender, EventArgs e)
        {

        }
    }
}
