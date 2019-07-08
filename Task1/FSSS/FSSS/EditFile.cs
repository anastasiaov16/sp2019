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
    public partial class EditFile : Form
    {
       private int id1;
       private IFileLogic fileLogic = CommonAp.FileLogic;

        private void CheckEditFile(TextBox a, TextBox b)
        {
            if (String.IsNullOrEmpty(a.Text) || String.IsNullOrEmpty(b.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }

            else if (OldTitleBox.Text == NewTitleBox.Text)
            {
                MessageBox.Show("Same values entered. Check the input, please");
            }

            else if (fileLogic.GetTitleForDelete(id1, a.Text) == 0)
            {
                MessageBox.Show("Old title is incorrect. Check the input, please");
            }
            else
            {
                fileLogic.UpdateFile("UpdateFile", OldTitleBox.Text, NewTitleBox.Text, id1);
            }
        }
        public EditFile(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            CheckEditFile(OldTitleBox, NewTitleBox);

            Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
