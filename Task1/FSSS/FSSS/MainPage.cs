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
    public partial class MainPage : Form
    {
        int id = 0;
        public MainPage(int k)
        {
            InitializeComponent();
            var fileLogic = CommonAp.FileLogic;
            fileLogic.ShowFile("GetAllFiles", dataGridView1, k);
            id = k;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFile form = new AddFile(id);
            form.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var fileLogic = CommonAp.FileLogic;
            fileLogic.ShowFile("GetAllFiles", dataGridView1, id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete form = new Delete(id);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditFile form = new EditFile(id);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendFile form = new SendFile(id);
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var fileLogic = CommonAp.FileLogic;
            try
            {
                fileLogic.FindFile("FindFile", dataGridView1, textBox1.Text, id);
            }
            catch (System.Data.SqlClient.SqlException sql)
            {
                if (sql.Number == 515)
                {
                    MessageBox.Show("Invalid values entered. Check the input, please");
                }
            }
            textBox1.Clear();
        }
    }
}
