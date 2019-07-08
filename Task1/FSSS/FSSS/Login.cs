using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FSSS.COMMON;
using FSSS.BLL.Interface;

namespace FSSS
{
    public partial class Login : Form
    {
        private IUserLogic userLogic = CommonAp.UserLogic;
        private int id;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            id = userLogic.QuerySqlShow("LogPas", LoginBox.Text, PasswordBox.Text);
            if (id > 0)
            {
                MainPage form = new MainPage(id);
                form.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Invalid login or password");
            }
        }
    }
}
