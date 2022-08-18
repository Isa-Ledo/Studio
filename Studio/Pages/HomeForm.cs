﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studio.Pages
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm();
            Hide();
            inventoryForm.Show();   
        }
    }
}