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
    public partial class DeletedProduct : Form
    {
		public DeletedProduct(string name)
		{
			InitializeComponent();

            label1.Text = $"Produktet {name} er slettet";
		}

		private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
            Products products = new Products();
            products.Show();
        }
    }
}
