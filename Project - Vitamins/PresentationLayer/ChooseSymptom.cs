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
    public partial class ChooseSymptom : Form
    {
        public ChooseSymptom()
        {
            InitializeComponent();
        }

        private void HomeSymptomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHome newForm = new UserHome();
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

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            OrderConfirmation newForm = new OrderConfirmation();
            newForm.ShowDialog();
        }

        private void ChooseSymptom_Load(object sender, EventArgs e)
        {

        }
    }
}
