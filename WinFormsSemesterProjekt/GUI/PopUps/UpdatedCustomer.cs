using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSemesterProjekt.GUI.PopUps
{
    public partial class UpdatedCustomer : Form
    {
        public UpdatedCustomer(string customerName)
        {
            InitializeComponent();
            labelText.Text = $"Oplysninger for kunden {customerName} er opdateret.";
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
