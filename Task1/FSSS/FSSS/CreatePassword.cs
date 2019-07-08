using FSSS.BLL.Interface;
using FSSS.COMMON;
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
    public partial class CreatePassword : Form
    {
        private int id1;
        private IUserLogic userLogic = CommonAp.UserLogic;

        private void CheckPassword(TextBox a, TextBox b)
        {
            if (String.IsNullOrEmpty(a.Text) || String.IsNullOrEmpty(b.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }

            else if (a.Text == b.Text )
            {
                MessageBox.Show("Passwords must be different. Try again");
            }

            else if (userLogic.GetPasswordForCreate(id1, a.Text) == 0)
            {
                MessageBox.Show("Old password is incorrect. Check the input, please");
            }

            else
            {
                userLogic.ChangePassword("ChangePassword", OldPasswordBox.Text, NewPasswordBox.Text, id1);
            }
        }

        public CreatePassword(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void CreatePassword_Load(object sender, EventArgs e)
        {

        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            CheckPassword(OldPasswordBox, NewPasswordBox);

           // MessageBox.Show("Your password successfuly changed");

            Close();            
        }
    }
}
