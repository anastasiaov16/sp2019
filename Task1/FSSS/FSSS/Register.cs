using FSSS.BLL.Interface;
using FSSS.COMMON;
using FSSS.Entitie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSSS
{
    public partial class Register : Form
    {
        private IUserLogic userLogic = CommonAp.UserLogic;

        private void CheckRegistrate(TextBox a, TextBox b, TextBox c, User user)
        {
            if (String.IsNullOrEmpty(a.Text) || String.IsNullOrEmpty(b.Text) || String.IsNullOrEmpty(c.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }

            else if (userLogic.GetPasswordForRegistrate(c.Text) == 1)
            {
                MessageBox.Show("This password is already taken");
            }

            else
            {
                userLogic.Registrate("Registrate", user);
            }
        }

        public Register()
        {
            InitializeComponent();
        }

        private void RegistBtn_Click(object sender, EventArgs e)
        {
            User user = new User(NameBox.Text, LoginBox.Text, PasswordBox.Text);

            CheckRegistrate(NameBox, LoginBox, PasswordBox, user);

            Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
