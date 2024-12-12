using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsSemesterProjekt.DataBase;

namespace WinFormsSemesterProjekt.GUI.PopUps
{
    public partial class ConfirmDeletionProduct : Form
    {
        public int ProductID { get; set; }

        public string Name { get; set; }
        
        public ConfirmDeletionProduct()
        {
            InitializeComponent();
        }

        public ConfirmDeletionProduct(int productId, string name)
        {
			InitializeComponent();

            ProductID = productId;

            Name = name;

            label1.Text = $"Er du sikker på, at du\r\nvil slette {name}?";
		}

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductDatabase.DeleteProduct(ProductID);
            DeletedProduct deletedProduct = new DeletedProduct(Name);
            deletedProduct.Show();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
            Products products = new Products();
            products.Show();
        }
    }
}
