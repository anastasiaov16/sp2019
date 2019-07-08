using FSSS.BLL.Interface;
using FSSS.COMMON;
using FSSS.Entitie;
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
        private int id1;
        private IFileLogic fileLogic = CommonAp.FileLogic;

        private void CheckAdd(TextBox a, TextBox b, File file)
        {
            if (String.IsNullOrEmpty(a.Text) || String.IsNullOrEmpty(b.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }
            else
            {
                fileLogic.AddFile("AddFile", file, id1);
            }
        }

        public AddFile(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void AddFile_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            File file = new File(TitleBox.Text, dateTimePicker1.Value, int.Parse(SizeBox.Text));

            CheckAdd(TitleBox, SizeBox, file);

            //fileLogic.AddFile("AddFile", file, id1);

            Close();
        }
    }
}
