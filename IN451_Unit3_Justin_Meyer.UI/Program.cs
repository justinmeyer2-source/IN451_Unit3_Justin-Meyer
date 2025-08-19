using IN451_Unit3_Justin_Meyer.Business;
using System;
using System.Windows.Forms;

namespace IN451_Unit3_Justin_Meyer.UI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var login = new LoginForm())
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;

                var service = new CustomerService(login.ServerName, login.DatabaseName, login.Username, login.Password);

                if (!service.TestConnection(out string err))
                {
                    MessageBox.Show($"Login failed: {err}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Application.Run(new Form1(service));
            }
        }
    }
}
