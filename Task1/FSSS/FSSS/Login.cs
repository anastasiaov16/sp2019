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

namespace FSSS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userLogic = CommonAp.UserLogic;
            var k = userLogic.QuerySqlShow("logpas", textBox1.Text, textBox2.Text);
            if (k > 0)
            {
                MainPage form = new MainPage(k);
                form.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Invalid login or password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();

        }
    }
}
