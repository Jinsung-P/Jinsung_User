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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private String strSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\Users\\park5\\OneDrive\\바탕 화면\\" +
            "Jinsung_User.accdb;Mode=ReadWrite";
        String iDSCCheck = "";
        String iDOverLapCheck = "";


        /////////////////////////////// 비밀번호  ///////////////////////////////
        private void tbPwOk_TextChanged(object sender, EventArgs e)
        {
            if(tbPw.Text.Length >= 8)
            {
                if (tbPw.Text == tbPwOk.Text)
                {
                    lbPwOk.Text = "* 비밀번호가 일치합니다.";
                    lbPwOk.ForeColor = Color.Green;
                }
                else
                {
                    lbPwOk.Text = "* 비밀번호가 일치하지 않습니다.";
                    lbPwOk.ForeColor = Color.Red;
                }
            }
            else
            {
                lbPwOk.Text = "";
            }
            
        }

        private void tbPw_TextChanged(object sender, EventArgs e)
        {
            SignUpClass sUC = new SignUpClass();
            if (sUC.IdSpecialCharater(tbPw.Text))
            {
                lbPwStep.Text = "위험";
                lbPwStep.ForeColor = Color.Red;
            }

            if (tbPw.Text == tbPwOk.Text)
            {
                lbPwOk.Text = "* 비밀번호가 일치합니다.";
                lbPwOk.ForeColor = Color.Green;
            }
            else
            {
                lbPwOk.Text = "* 비밀번호가 일치하지 않습니다.";
                lbPwOk.ForeColor = Color.Red;
            }
        }
        /////////////////////////////// 아이디  ///////////////////////////////
        private void btOverLap_Click(object sender, EventArgs e)
        {
            if (iDSCCheck == "no")
            {
                MessageBox.Show("입력하신 아이디를 사용할 수 없습니다!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                // 중복 확인 값
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            SignUpClass sUC = new SignUpClass();
            if (sUC.IdSpecialCharater(tbId.Text)==true)
            {
                lbIdSCCheck.ForeColor = Color.Red;
                iDSCCheck = "no";
            }
            else
            {
                lbIdSCCheck.ForeColor = Color.Black;
                iDSCCheck = "yes";
            }
        }
        /////////////////////////////// 테스트  ///////////////////////////////
        private void btTest_Click(object sender, EventArgs e)
        {
            var conn = new OleDbConnection(strSQL);
            conn.Open();
            String sql = "SELECT ID INTO @idOverLapCheck FROM USER_INFORMATION WHERE ID = '" + tbId.Text + "'";
            var comm = new OleDbCommand(sql, conn);
            var myRead = comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["ID"].ToString(), myRead["PASSWORD"].ToString(), myRead["BIRTH"].ToString(), myRead["SEX"].ToString(), myRead["MAIL"].ToString() };
            }
            myRead.Close();
            conn.Close();

            lbTest.Text = iDOverLapCheck;
        }
    }
}
