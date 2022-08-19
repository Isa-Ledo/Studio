using Studio.Models.Enum;

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
    public partial class NewProductForm : Form
    {
        public readonly InventoryForm InventoryForm;
        public NewProductForm(InventoryForm inventoryForm)
        {
            InitializeComponent();
            InventoryForm = inventoryForm;
            InventoryForm.Hide();
            Show();
        }

        private void ButtonBacktoCategories_Click(object sender, EventArgs e)
        {
            Hide();
            InventoryForm.Show();
        }
    }
}
