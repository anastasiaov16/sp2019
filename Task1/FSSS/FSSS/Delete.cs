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
    public partial class Delete : Form
    {
        int id1 = 0;
        public Delete(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileLogic = CommonAp.FileLogic;
            try
            {
                fileLogic.DeleteFile("DeleteFile", textBox1.Text, dateTimePicker1.Value, id1);
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

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
