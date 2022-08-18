using Studio.Pages.Inventory;

namespace Studio.Pages
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void buttonJewelry_Click(object sender, EventArgs e)
        {
            var jewelryForm = new JewelryForm();
            Hide();
            jewelryForm.Show();   
        }

        private void buttonNeedles_Click(object sender, EventArgs e)
        {
            var needlesForm = new NeedlesForm();
            Hide();
            needlesForm.Show();
        }

        private void buttonDisposables_Click(object sender, EventArgs e)
        {
            var disposablesForm = new DisposablesForm();
            Hide();
            disposablesForm.Show();
        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            var homeForm = new HomeForm();
            Hide();
            homeForm.Show();    
        }

        private void buttonCleaningProducts_Click(object sender, EventArgs e)
        {
            var cleaningProductsForm = new CleaningProductsForm();
            Hide();
            cleaningProductsForm.Show();
        }

        private void buttonSterilization_Click(object sender, EventArgs e)
        {
            var sterilizationForm = new SterilizationForm();
            Hide();
            sterilizationForm.Show();   
        }

        private void buttonBiosecutiry_Click(object sender, EventArgs e)
        {
            var biosecurityForm = new BiosecurityForm();
            Hide();
            biosecurityForm.Show(); 
        }

        private void buttonInstrumentals_Click(object sender, EventArgs e)
        {
            var instrumentalsForm = new InstrumentalsForm();
            Hide();
            instrumentalsForm.Show();
        }
    }
}
