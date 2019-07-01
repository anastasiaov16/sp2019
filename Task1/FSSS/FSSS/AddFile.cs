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
    public partial class AddFile : Form
    {
        int id1 = 0;
        public AddFile(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileLogic = CommonAp.FileLogic;
            try
            {
                fileLogic.AddFile("AddFile", textBox1.Text, dateTimePicker1.Value, int.Parse(textBox3.Text), id1);
            }
            catch (System.Data.SqlClient.SqlException sql)
            {
                if (sql.Number == 515)
                {
                    MessageBox.Show("Invalid values entered. Check the input, please");
                }
            }
            textBox1.Clear();
            textBox3.Clear();
            Hide();
        }

        private void AddFile_Load(object sender, EventArgs e)
        {

        }
    }
}
