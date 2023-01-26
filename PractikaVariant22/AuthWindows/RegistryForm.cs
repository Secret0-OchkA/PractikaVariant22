
using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractikaVariant22.AuthWindows
{
    public partial class RegistryForm : Form
    {
        private readonly Form parent;

        AuthService authService = new AuthService();

        public RegistryForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void RegistryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void TextBox_PasswordShow(object sender, EventArgs e)
        {
            if(sender is TextBox textBox)
            {
                textBox.UseSystemPasswordChar = false;
            }
        }
        private void TextBox_PasswordHide(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.UseSystemPasswordChar = true;
            }
        }

        private async void button_Registre_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string email = textBox_Email.Text;
            string password = textBox_Password.Text;
            string confirmPassword = textBox_ConfirmPassword.Text;

            if (!password.Equals(confirmPassword)) return;

            bool res = await authService.Registry(new User() { Name = name, Email = email, Password = password });
            if (!res) return;

            this.Close();
            parent.Show();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
