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
    public partial class SendFile : Form
    {
        int id = 0;
        public SendFile(int i)
        {
            InitializeComponent();
            id = i;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileLogic = CommonAp.FileLogic;
            try
            {
                fileLogic.SendFile("SendFile", textBox1.Text, textBox2.Text, id);
            }
            catch(System.Data.SqlClient.SqlException sql)
            {
                if (sql.Number == 515)
                {
                    MessageBox.Show("Invalid values entered. Check the input, please");
                }
            }

            textBox1.Clear();
            textBox2.Clear();
            Hide();

        }

        private void SendFile_Load(object sender, EventArgs e)
        {

        }
    }
}
