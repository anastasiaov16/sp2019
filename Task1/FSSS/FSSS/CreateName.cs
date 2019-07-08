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
    public partial class CreateName : Form
    {
        private int id1;
        private IUserLogic userLogic = CommonAp.UserLogic;


        private void Check(TextBox a, TextBox b)
        {
            if (String.IsNullOrEmpty(a.Text) || String.IsNullOrEmpty(b.Text))
            {
                MessageBox.Show("Invalid values entered. Check the input, please");
            }

            else if (OldNameBox.Text == NewNameBox.Text)
            {
                MessageBox.Show("Same values entered. Check the input, please");
            }

            else if (userLogic.GetNameForCreate(id1, a.Text) == 0)
            {
                MessageBox.Show("Old name is incorrect. Check the input, please");
            }

            else
            {
                userLogic.ChangeName("ChangeName", OldNameBox.Text, NewNameBox.Text, id1);
            }
        }

      
        public CreateName(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeNameBtn_Click(object sender, EventArgs e)
        {
            Check(OldNameBox, NewNameBox);

           // MessageBox.Show("Your name successfuly changed");

            Close();                
        }

        private void CreateName_Load(object sender, EventArgs e)
        {

        }
    }
}
