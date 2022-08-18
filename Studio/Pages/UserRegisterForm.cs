using Studio.Database;
using Studio.Database.Repository;
using Studio.Models.Repository;

using System;
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
    }
}
