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
    public partial class OrderTypeSelection : Form
    {
        public OrderTypeSelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddSalesOrder addSalesOrder = new AddSalesOrder();
            addSalesOrder.Show();
        }

        private void buttonProductionOrder_Click(object sender, EventArgs e)
        {
            this.Close();
            AddProductionOrder addProductionOrder = new AddProductionOrder();
            addProductionOrder.Show();
            Orders orders = new Orders();
            orders.Hide();
        }
    }
}
