using Studio.Database;
using Studio.Database.Repository;
using Studio.Models.Enum;
using System.ComponentModel;
using Studio.Models.Repository;

namespace Studio.Pages.Inventory
{
    public partial class CategoryForm : Form
    {
        public CategoryEnum CategoryId { get; set; }

        public ProductRepository _productRepository;

        public InventoryForm InventoryForm { get; set; }

        public CategoryForm(CategoryEnum categoryId, InventoryForm inventoryForm)
        {
            _productRepository = new ProductRepository(new Connection());
            InitializeComponent();
            CategoryId = categoryId;
            InventoryForm = inventoryForm;
            InventoryForm.Hide();
        }

        private void buttonBacktoInventory_Click(object sender, EventArgs e)
        {
            Hide();
            InventoryForm.Show();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            var products =  _productRepository.GetProductByCategoryId((int)CategoryId);        
            DataGridProductsView.DataSource = new BindingList<ProductEntity>(products);
        }

        private void ProductsForm_Closing(object sender, CancelEventArgs e)
        {
           
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            var newproductForm = new NewProductForm(InventoryForm, CategoryId);
            Hide();
            newproductForm.Show();  
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
