namespace Studio.Models
{
    public class LoginModel
    {
        public LoginModel(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public string Login { get; }

        public string Senha { get; }
    }
}
