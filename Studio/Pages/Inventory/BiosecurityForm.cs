using Studio.Database;
using Studio.Database.Repository;
using Studio.Models.Repository;
using System.Linq;

namespace Studio.Pages.Inventory
{
    public partial class BiosecurityForm : Form
    {
        public ProductRepository _productRepository;

        public BiosecurityForm()
        {
            _productRepository = new ProductRepository(new Connection());
            InitializeComponent();
        }

        private void buttonBacktoInventory_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm();
            Hide();
            inventoryForm.Show();
        }

        private void BiosecurityForm_Load(object sender, EventArgs e)
        {
            var products = _productRepository.GetProductByCategoryId(1);
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            var newproductForm = new NewProductForm();
            Hide();
            newproductForm.Show();  
        }
    }
}
