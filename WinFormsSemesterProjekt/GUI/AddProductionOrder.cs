﻿using System;
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
    public partial class AddProductionOrder : Form
    {
        public AddProductionOrder()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreatedOrder createdOrder = new CreatedOrder();
            createdOrder.Show();
        }
    }
}
