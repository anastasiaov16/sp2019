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
    public partial class ViewProfile : Form
    {
        private int id1 = 0;
        private IFileLogic fileLogic = CommonAp.FileLogic;


        public ViewProfile(int id)
        {
            InitializeComponent();
            fileLogic.ShowFile("GetUser", dataGridView1, id);
            id1 = id;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Name")
            {
                CreateName form = new CreateName(id1);
                form.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Password")
            {
                CreatePassword form = new CreatePassword(id1);
                form.Show();
            }

            //Hide();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
