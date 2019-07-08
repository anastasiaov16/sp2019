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
    public partial class MainPage : Form
    {
        private int id;
        private IFileLogic fileLogic = CommonAp.FileLogic;

        private void CheckFindFile(TextBox a)
        {
            if (String.IsNullOrEmpty(a.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }

            else if (fileLogic.GetTitleForDelete(id, a.Text) == 0)
            {
                MessageBox.Show("No such file exists");
            }
        }

        public MainPage(int k)
        {
            InitializeComponent();     
            fileLogic.ShowFile("GetAllFiles", dataGridView1, k);
            id = k;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void EditFileBtn_Click(object sender, EventArgs e)
        {
            EditFile form = new EditFile(id);
            form.Show();
        }

        private void ViewProfileBtn_Click(object sender, EventArgs e)
        {
            ViewProfile form = new ViewProfile(id);
            form.Show();
        }

        private void DeleteFileBtn_Click(object sender, EventArgs e)
        {
            Delete form = new Delete(id);
            form.Show();
        }

        private void SendFileBtn_Click(object sender, EventArgs e)
        {
            SendFile form = new SendFile(id);
            form.Show();
        }

        private void UpdateTableBtn_Click(object sender, EventArgs e)
        {
            fileLogic.ShowFile("GetAllFiles", dataGridView1, id);
        }

        private void FindFileBtn_Click(object sender, EventArgs e)
        {
            fileLogic.FindFile("FindFile", dataGridView1, FindBox.Text, id);

            CheckFindFile(FindBox);
        }

        private void AddFileBtn_Click(object sender, EventArgs e)
        {
            AddFile form = new AddFile(id);
            form.Show();
        }
    }
}
