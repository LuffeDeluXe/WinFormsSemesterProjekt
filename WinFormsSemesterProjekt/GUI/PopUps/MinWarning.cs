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
    public partial class MinWarning : Form
    {
        public MinWarning()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            AddProductionOrder addProductionOrder = new AddProductionOrder();
            addProductionOrder.Show();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
