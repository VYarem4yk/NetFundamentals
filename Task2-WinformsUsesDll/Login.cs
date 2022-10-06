using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2_Multitargeting;

namespace Task2_WinformsUsesDll
{
    public partial class Login : Form
    {

        Greetings greetings = new Greetings();
        public Login()
        {
            InitializeComponent();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameTextBox.Text))
            {
                outputUsername.Text = greetings.GenerateGreetings(userNameTextBox.Text);
            }
            else
            {
                outputUsername.Text = string.Empty;
            }
        }
    }
}
