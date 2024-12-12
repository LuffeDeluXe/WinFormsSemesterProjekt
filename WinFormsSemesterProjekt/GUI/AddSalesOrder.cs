using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsSemesterprojekt.Models;
using WinFormsSemesterProjekt.GUI.PopUps;

namespace WinFormsSemesterProjekt.GUI
{
    public partial class AddSalesOrder : Form
    {
        public BindingList<ProductLine> Lines {  get; set; } = new BindingList<ProductLine>();
        public AddSalesOrder()
        {
            InitializeComponent();

            productLineDataView.DataSource = Lines;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreatedOrder createdOrder = new CreatedOrder();
            createdOrder.Show();
        }

        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            WinAddProductLine productLine = new WinAddProductLine();
            productLine.Show();
            this.Hide();
        }
    }
}
