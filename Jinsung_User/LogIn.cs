using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jinsung_User
{
    public partial class logIn : Form
    {
        bool textBoxClear()
        {
            if(tbId.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public logIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            SignUp sU = new SignUp();
            sU.ShowDialog();
        }

        private void lbSearchId_Click(object sender, EventArgs e)
        {
            SearchId sI = new SearchId();
            sI.ShowDialog();
        }

        private void lbSearchPw_Click(object sender, EventArgs e)
        {
            SearchPw sP = new SearchPw();
            sP.ShowDialog();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            if(textBoxClear() == false)
            {
                MessageBox.Show("아이디를 입력하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbPw_CheckedChanged(object sender, EventArgs e)
        {
            if(cbPw.Checked == true)
            {
                tbPw.PasswordChar = default(char);
            }
            else
            {
                tbPw.PasswordChar = '*';
            }
        }
    }
}
