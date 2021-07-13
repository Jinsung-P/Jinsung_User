using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


using System.Data.SqlClient;
using System.Data.Odbc;

namespace Jinsung_User
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\Users\\park5\\OneDrive\\바탕 화면\\" +
            "Jinsung_User.accdb;Mode=ReadWrite";
      

        String password = "";
        String matchNum = "[^0-9]";


        private void bttest_Click(object sender, EventArgs e)
        {
           
            
        }

       

        private void tbPw2_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPw.Text == tbPw2.Text)
            {
                lbPwAgreement.ForeColor = Color.Blue;
                lbPwAgreement.Text = "* 비밀번호가 일치합니다.";
                password = "ok";
            }
            else
            {
                lbPwAgreement.ForeColor = Color.Red;
                lbPwAgreement.Text = "* 비밀번호가 불일치합니다.";
                password = "no";
            }
        }

        private void tbPw_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPw.Text == tbPw2.Text)
            {
                lbPwAgreement.ForeColor = Color.Blue;
                lbPwAgreement.Text = "* 비밀번호가 일치합니다.";
                password = "ok";

            }
            else
            {
                lbPwAgreement.ForeColor = Color.Red;
                lbPwAgreement.Text = "* 비밀번호가 불일치합니다.";
                password = "no";
            }
        }

       

        private void tbId_KeyUp(object sender, KeyEventArgs e)
        {
            SignUpClass iC = new SignUpClass();

            if (iC.IdSpecialCharater(tbId.Text) == true)
            {
                lbIdWarning.Text = "* ID에는 영어와 숫자만 사용할 수 있습니다!";
                lbIdWarning.ForeColor = Color.Red;
            }
            else
            {
                lbIdWarning.Text = "";
                lbIdWarning.ForeColor = Color.Red;
            }
        }

      

        private void btSignUp_Click(object sender, EventArgs e)
        {
            if (password == "ok")
            {
                MessageBox.Show("회원가입을 완료하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("회원가입을 완료할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void btOverLap_Click(object sender, EventArgs e)
        {
            var conn = new OleDbConnection(StrSQL);
        }
    }
}
