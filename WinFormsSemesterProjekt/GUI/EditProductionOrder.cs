using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt.GUI
{
    public partial class EditProductionOrder : Form
    {
        public EditProductionOrder()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdatedOrder updatedOrder = new UpdatedOrder();
            updatedOrder.Show();
        }
    }
}
