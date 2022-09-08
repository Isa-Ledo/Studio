
namespace Studio.Pages
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ButtonInventory_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm(this);
        }

        private void inventoryMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryForm = new InventoryForm(this);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do usuário?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                var loginForm = new LoginForm();
                this.Close();
                loginForm.Show();
            }
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                Application.Exit();
        }
    }
}
