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
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void buttonBacktoCategories_Click(object sender, EventArgs e)
        {
            var biosecutiryForm = new BiosecurityForm();
            Hide();
            biosecutiryForm.Show();
        }
    }
}
