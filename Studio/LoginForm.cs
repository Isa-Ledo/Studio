using Studio.Database;
using Studio.Database.Repository;
using Studio.Models;
using Studio.Pages;

namespace Studio
{
    public partial class LoginForm : Form
    {
        public UserRepository _userRepository;
        public LoginForm()
        {
            _userRepository = new UserRepository(new Connection());
            InitializeComponent();
        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            var login = new LoginModel(textboxLogin.Text, textboxSenha.Text);

            var user = _userRepository.GetUserByLogin(login);

            if (user != null) 
            {
                var homeForm = new HomeForm();
                Hide();
                homeForm.Show();
            }
            else
            {
                LabelError.Visible = true;
                LabelError.Text = "Usuário e senha incorretos";
                textboxLogin.Text = string.Empty;
                textboxSenha.Text = string.Empty;
            }
        }

        private void ButtonShowPassword_Click(object sender, EventArgs e)
        {
            if (textboxSenha.PasswordChar == '\0')
                textboxSenha.PasswordChar = '*';
            else
               textboxSenha.PasswordChar = '\0';
        }

        private void LinkLabelCadastro_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var userRegisterForm = new UserRegisterForm();
            Hide();
            userRegisterForm.Show();
            
        }

        private void textboxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                ButtonEntrar_Click(sender, e);
        }
    }
}
