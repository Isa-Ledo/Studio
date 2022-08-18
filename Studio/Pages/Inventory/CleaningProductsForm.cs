using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio.Pages.Inventory
{
    public partial class CleaningProductsForm : Form
    {
        public CleaningProductsForm()
        {
            InitializeComponent();
        }

        private void buttonBacktoInventory_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm();
            Hide();
            inventoryForm.Show();
        }
    }
}
