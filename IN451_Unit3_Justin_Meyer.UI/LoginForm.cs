using System;
using System.Windows.Forms;
using IN451_Unit3_Justin_Meyer.Business;

namespace IN451_Unit3_Justin_Meyer.UI
{
    public partial class LoginForm : Form
    {
        public string ServerName => txtServer.Text.Trim();
        public string DatabaseName => txtDatabase.Text.Trim();
        public string Username => txtUser.Text.Trim();
        public string Password => txtPassword.Text;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(ServerName))
            {
                errorProvider1.SetError(txtServer, "Server is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(DatabaseName))
            {
                errorProvider1.SetError(txtDatabase, "Database is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(Username))
            {
                errorProvider1.SetError(txtUser, "User is required.");
                return;
            }
            var svc = new CustomerService(ServerName, DatabaseName, Username, Password);
            if (!svc.TestConnection(out string err))
            {
                MessageBox.Show($"Could not connect. {err}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
