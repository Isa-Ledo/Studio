using Studio.Database;
using Studio.Database.Repository;
using Studio.Models.Repository;

namespace Studio.Pages
{
    public partial class UserRegisterForm : Form
    {
        public UserRepository _userRepository;

        public UserRegisterForm()
        {
            _userRepository = new UserRepository(new Connection());
            InitializeComponent();
        }

        private void LabelEmail_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var user = new UserEntity(0, TextBoxName.Text, TextBoxEmail.Text, TextBoxPassword.Text, DateTimePicker.Value);
            _userRepository.SaveUser(user);
        }

        private void UserRegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                Application.Exit();
        }
    }
}
