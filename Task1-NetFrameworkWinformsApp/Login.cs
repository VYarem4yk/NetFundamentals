using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_NetFrameworkWinformsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameTextBox.Text))
            {
                outputUsername.Text = $"Hello {userNameTextBox.Text}!";
            }
            else
            {
                outputUsername.Text = string.Empty;
            }
        }
    }
}
