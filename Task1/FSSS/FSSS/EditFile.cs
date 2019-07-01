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
    public partial class EditFile : Form
    {
        int id1 = 0;
        public EditFile(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditFile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileLogic = CommonAp.FileLogic;
            try
            {
                fileLogic.UpdateFile("UpdateFile", textBox1.Text, textBox2.Text, id1);
            }
            catch (System.Data.SqlClient.SqlException sql)
            {
                if (sql.Number == 515)
                {
                    MessageBox.Show("Invalid values entered. Check the input, please");
                }
            }
            textBox1.Clear();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
