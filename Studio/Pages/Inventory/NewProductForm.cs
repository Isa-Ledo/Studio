using Studio.Database;
using Studio.Database.Repository;
using Studio.Models.Enum;
using Studio.Models.Repository;

namespace Studio.Pages.Inventory
{
    public partial class NewProductForm : Form
    {
        public readonly InventoryForm InventoryForm;

        public CategoryEnum CategoryId { get; set; }

        public ProductRepository _productRepository { get; set; }


        public NewProductForm(InventoryForm inventoryForm, CategoryEnum categoryId)
        {
            InitializeComponent();
            _productRepository= new ProductRepository(new Connection());
            CategoryId = categoryId;
            InventoryForm = inventoryForm;
            InventoryForm.Hide();
            Show();
        }

        private void ButtonBacktoCategories_Click(object sender, EventArgs e)
        {
            Hide();
            ShowProductsForm(CategoryId);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var productEntity = new ProductEntity(0, textBoxName.Text, decimal.Parse(textBoxPrice.Text), decimal.Parse(textBoxCostPrice.Text), int.Parse(textBoxQuantity.Text), CategoryId);
            _productRepository.SaveProduct(productEntity);
            MessageBox.Show("Produto adicionado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textBoxName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxQuantity.Text = string.Empty;
            textBoxCostPrice.Text = string.Empty;
        }

        private void ShowProductsForm(CategoryEnum category)
        {
            var productsForm = new CategoryForm(category, InventoryForm);
            productsForm.ShowDialog();
        }

        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSave_Click(sender, e);
        }

        private void NewProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                Application.Exit();
        }
    }
}
