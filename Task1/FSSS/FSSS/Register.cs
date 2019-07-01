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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userLogic = CommonAp.UserLogic;
            try
            {
                userLogic.Registrate("Registrate", textBox1.Text, textBox2.Text, textBox3.Text);
            }
            catch (System.Data.SqlClient.SqlException sql)
            {
                if (sql.Number == 2627 || sql.Number == 2601)
                    MessageBox.Show("This login is already taken");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
