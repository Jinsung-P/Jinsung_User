using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace JInsung_user
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }


        private void btButton_Click(object sender, EventArgs e)
        {
            if(tbId.Text == "" || tbPw.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPw.Checked == true)
            {
                tbPw.PasswordChar = default(char) ;
            }
            else
            {
                tbPw.PasswordChar = '*';
            }

            var Conn = new OleDbConnection();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            SignUp sU = new SignUp();
            sU.ShowDialog();
        }
    }
}
