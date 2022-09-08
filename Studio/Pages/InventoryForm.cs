using Studio.Models.Enum;
using Studio.Pages.Inventory;

namespace Studio.Pages
{
    public partial class InventoryForm : Form
    {
        public HomeForm Home { get; set; }
        public InventoryForm(HomeForm form)
        {
            Home = form;
            Home.Hide();
            Show();
            InitializeComponent();
        }
        
        private void buttonJewelry_Click(object sender, EventArgs e)
        {
            ShowProductsForm(CategoryEnum.Jewelry);
        }

        private void buttonNeedles_Click(object sender, EventArgs e)
        {
            ShowProductsForm(CategoryEnum.Needles);
        }

        private void buttonDisposables_Click(object sender, EventArgs e)
        {
            ShowProductsForm(CategoryEnum.Disposables);
        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            Hide();
            Home.Show();
        }

        private void buttonCleaningProducts_Click(object sender, EventArgs e)
        {
            ShowProductsForm(CategoryEnum.CleaningProducts);
        }

        private void buttonSterilization_Click(object sender, EventArgs e)
        {
            ShowProductsForm(CategoryEnum.Sterilization);
        }

        private void buttonInstrumentals_Click(object sender, EventArgs e)
        {
            ShowProductsForm(CategoryEnum.Instrumentals);
        }
        private void buttonAntisepsis_Click(object sender, EventArgs e)
        {
            ShowProductsForm(CategoryEnum.Antisepsis);
        }

        private void buttonEPI_Click(object sender, EventArgs e)
        {
            ShowProductsForm(CategoryEnum.EPI);
        }

        private void ShowProductsForm(CategoryEnum category)
        {
            var productsForm = new CategoryForm(category, this);
            productsForm.ShowDialog();
        }

        private void InventoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                Application.Exit();
        }
    }
}
