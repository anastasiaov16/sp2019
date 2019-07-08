using FSSS.BLL;
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
    public partial class Delete : Form
    {
        private int id1;
        private IFileLogic fileLogic = CommonAp.FileLogic;

        private void CheckTextBoxDelete(TextBox a)
        {
            if (String.IsNullOrEmpty(a.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }

            else if (fileLogic.GetTitleForDelete(id1, a.Text) == 0)
            {
                MessageBox.Show("No such file exists. Check the input, please");
            }

            else
            {
                fileLogic.DeleteFile("DeleteFile", TitleBox1.Text, dateTimePicker1.Value, id1);
            }
        }
        public Delete(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            CheckTextBoxDelete(TitleBox1);

            // MessageBox.Show("File successfully deleted");
            Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
