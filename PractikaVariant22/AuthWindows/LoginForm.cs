


using Domain;
using Infrastructura;
using PractikaVariant22.RoleWindows;
using Services;
using System;
using System.Windows.Forms;

namespace PractikaVariant22.AuthWindows
{
    public partial class LoginForm : Form
    {
        AuthService authService;
        public LoginForm()
        {
            InitializeComponent();

            authService = new AuthService();
        }

        private async void button_Login_Click(object sender, EventArgs e)
        {
            string email = textBox_Name.Text;
            string password = textBox_Password.Text;

            User user = await authService.Login(email, password);
            if (user == null)
            {
                MessageBox.Show("Incorrect login or password");
                return;
            }

            AuthContext.curUser = user;

            Form userForm = null;
            switch(user.Role)
            {
                case 0: userForm = new UserWindow(this); break;
                case 1: userForm = new ReporWindow(this); break;
            }

            this.Hide();
            userForm.Show();
        }

        private void button_Registry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new RegistryForm(this);
            form.Show();
        }

        private void textBox_Password_MouseEnter(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = false;
        }

        private void textBox_Password_MouseLeave(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
        }
    }
}
