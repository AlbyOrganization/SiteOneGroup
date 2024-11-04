using OneGroup.Class;

namespace OneGroup
{
    public partial class Login : Form
    {
        private List<User> users;
        public void ClearInput()
        {
            txtCodCli.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
        public Login()
        {
            InitializeComponent();

            users = new List<User>()
            {
                new User{IdUser = 1, Senha = "senha123"}
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int inputCode = Convert.ToInt32(txtCodCli.Text);
            string inputPassword = txtSenha.Text;

            User user = users.Find(user => user.IdUser == inputCode && user.Senha == inputPassword);

            if (user != null)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Código ou senha invaálidos. Tente Novamente.");
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }
    }

}
