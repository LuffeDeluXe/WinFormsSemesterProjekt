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
    public partial class CreatedCustomer : Form
    {
        public CreatedCustomer(string customerName)
        {
            InitializeComponent();
            labelText.Text = $"Kunden {customerName} er oprettet.";
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
