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
    public partial class SendFile : Form
    {
        private int id;
        private IFileLogic fileLogic = CommonAp.FileLogic;
        private IUserLogic userLogic = CommonAp.UserLogic;

        private void CheckSendFile(TextBox a, TextBox b)
        {
            if (String.IsNullOrEmpty(a.Text) || String.IsNullOrEmpty(b.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }

            else if (userLogic.GetLoginForSend(b.Text) == 0)
            {
                MessageBox.Show("Wrong user login");
            }

            else if (fileLogic.GetTitleForDelete(id, a.Text) == 0)
            {
                MessageBox.Show("No such file exists. Check the input, please");
            }

            else
            {
                fileLogic.SendFile("SendFile", TitleBox.Text, UserBox.Text, id);
            }
        }

        public SendFile(int i)
        {
            InitializeComponent();
            id = i;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            CheckSendFile(TitleBox, UserBox);

            Hide();
        }

        private void SendFile_Load(object sender, EventArgs e)
        {

        }
    }
}
