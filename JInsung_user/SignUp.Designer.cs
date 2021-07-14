
namespace JInsung_user
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btSignUp = new System.Windows.Forms.Button();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.tbPwOk = new System.Windows.Forms.TextBox();
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.tbPhoneMiddle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTest = new System.Windows.Forms.Label();
            this.cbMail = new System.Windows.Forms.ComboBox();
            this.tbPhoneLast = new System.Windows.Forms.TextBox();
            this.cbPhoneFirst = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tBSex = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btOverLap = new System.Windows.Forms.Button();
            this.lbOverLap = new System.Windows.Forms.Label();
            this.lbPwStep = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbPwOk = new System.Windows.Forms.Label();
            this.lbIdSCCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호 확인";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "생년월일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "전화번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "메일";
            // 
            // btSignUp
            // 
            this.btSignUp.Location = new System.Drawing.Point(313, 301);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(75, 23);
            this.btSignUp.TabIndex = 6;
            this.btSignUp.Text = "가입하기";
            this.btSignUp.UseVisualStyleBackColor = true;
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(138, 211);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(100, 21);
            this.tbMail.TabIndex = 7;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(138, 15);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 21);
            this.tbId.TabIndex = 8;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbPw
            // 
            this.tbPw.Location = new System.Drawing.Point(138, 54);
            this.tbPw.MaxLength = 15;
            this.tbPw.Name = "tbPw";
            this.tbPw.PasswordChar = '*';
            this.tbPw.Size = new System.Drawing.Size(100, 21);
            this.tbPw.TabIndex = 9;
            this.tbPw.TextChanged += new System.EventHandler(this.tbPw_TextChanged);
            // 
            // tbPwOk
            // 
            this.tbPwOk.Location = new System.Drawing.Point(138, 103);
            this.tbPwOk.MaxLength = 15;
            this.tbPwOk.Name = "tbPwOk";
            this.tbPwOk.PasswordChar = '*';
            this.tbPwOk.Size = new System.Drawing.Size(100, 21);
            this.tbPwOk.TabIndex = 10;
            this.tbPwOk.TextChanged += new System.EventHandler(this.tbPwOk_TextChanged);
            // 
            // tbBirth
            // 
            this.tbBirth.Location = new System.Drawing.Point(138, 139);
            this.tbBirth.MaxLength = 6;
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(65, 21);
            this.tbBirth.TabIndex = 11;
            // 
            // tbPhoneMiddle
            // 
            this.tbPhoneMiddle.Location = new System.Drawing.Point(207, 175);
            this.tbPhoneMiddle.MaxLength = 4;
            this.tbPhoneMiddle.Name = "tbPhoneMiddle";
            this.tbPhoneMiddle.Size = new System.Drawing.Size(46, 21);
            this.tbPhoneMiddle.TabIndex = 12;
            this.tbPhoneMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "@";
            // 
            // lbTest
            // 
            this.lbTest.AutoSize = true;
            this.lbTest.Location = new System.Drawing.Point(123, 306);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(25, 12);
            this.lbTest.TabIndex = 14;
            this.lbTest.Text = "test";
            // 
            // cbMail
            // 
            this.cbMail.FormattingEnabled = true;
            this.cbMail.Location = new System.Drawing.Point(267, 211);
            this.cbMail.Name = "cbMail";
            this.cbMail.Size = new System.Drawing.Size(121, 20);
            this.cbMail.TabIndex = 15;
            // 
            // tbPhoneLast
            // 
            this.tbPhoneLast.Location = new System.Drawing.Point(276, 175);
            this.tbPhoneLast.MaxLength = 4;
            this.tbPhoneLast.Name = "tbPhoneLast";
            this.tbPhoneLast.Size = new System.Drawing.Size(46, 21);
            this.tbPhoneLast.TabIndex = 16;
            this.tbPhoneLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbPhoneFirst
            // 
            this.cbPhoneFirst.FormattingEnabled = true;
            this.cbPhoneFirst.Items.AddRange(new object[] {
            "010",
            "011",
            "017",
            "019"});
            this.cbPhoneFirst.Location = new System.Drawing.Point(138, 177);
            this.cbPhoneFirst.Name = "cbPhoneFirst";
            this.cbPhoneFirst.Size = new System.Drawing.Size(50, 20);
            this.cbPhoneFirst.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "-";
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(218, 301);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 23);
            this.btTest.TabIndex = 21;
            this.btTest.Text = "Test";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "-";
            // 
            // tBSex
            // 
            this.tBSex.Location = new System.Drawing.Point(218, 139);
            this.tBSex.MaxLength = 1;
            this.tBSex.Name = "tBSex";
            this.tBSex.Size = new System.Drawing.Size(20, 21);
            this.tBSex.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 13F);
            this.label12.Location = new System.Drawing.Point(238, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "******";
            // 
            // btOverLap
            // 
            this.btOverLap.Location = new System.Drawing.Point(246, 13);
            this.btOverLap.Name = "btOverLap";
            this.btOverLap.Size = new System.Drawing.Size(75, 23);
            this.btOverLap.TabIndex = 25;
            this.btOverLap.Text = "중복확인";
            this.btOverLap.UseVisualStyleBackColor = true;
            this.btOverLap.Click += new System.EventHandler(this.btOverLap_Click);
            // 
            // lbOverLap
            // 
            this.lbOverLap.AutoSize = true;
            this.lbOverLap.Location = new System.Drawing.Point(327, 18);
            this.lbOverLap.Name = "lbOverLap";
            this.lbOverLap.Size = new System.Drawing.Size(115, 12);
            this.lbOverLap.TabIndex = 26;
            this.lbOverLap.Text = "* 중복 확인해주세요";
            // 
            // lbPwStep
            // 
            this.lbPwStep.AutoSize = true;
            this.lbPwStep.Location = new System.Drawing.Point(244, 57);
            this.lbPwStep.Name = "lbPwStep";
            this.lbPwStep.Size = new System.Drawing.Size(0, 12);
            this.lbPwStep.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 8F);
            this.label14.Location = new System.Drawing.Point(23, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(450, 11);
            this.label14.TabIndex = 28;
            this.label14.Text = "* 비밀번호는 반드시 8~15 길이의 대문자, 특수문자, 숫자를 하나 이상 포함하여야 합니다.";
            // 
            // lbPwOk
            // 
            this.lbPwOk.AutoSize = true;
            this.lbPwOk.Font = new System.Drawing.Font("굴림", 8F);
            this.lbPwOk.ForeColor = System.Drawing.Color.Red;
            this.lbPwOk.Location = new System.Drawing.Point(244, 107);
            this.lbPwOk.Name = "lbPwOk";
            this.lbPwOk.Size = new System.Drawing.Size(168, 11);
            this.lbPwOk.TabIndex = 29;
            this.lbPwOk.Text = "* 비밀번호가 일치하지 않습니다.";
            // 
            // lbIdSCCheck
            // 
            this.lbIdSCCheck.AutoSize = true;
            this.lbIdSCCheck.Location = new System.Drawing.Point(23, 39);
            this.lbIdSCCheck.Name = "lbIdSCCheck";
            this.lbIdSCCheck.Size = new System.Drawing.Size(255, 12);
            this.lbIdSCCheck.TabIndex = 30;
            this.lbIdSCCheck.Text = "* 아이디는 영어와 숫자만 사용할 수 있습니다!";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 345);
            this.Controls.Add(this.lbIdSCCheck);
            this.Controls.Add(this.lbPwOk);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbPwStep);
            this.Controls.Add(this.lbOverLap);
            this.Controls.Add(this.btOverLap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tBSex);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btTest);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPhoneFirst);
            this.Controls.Add(this.tbPhoneLast);
            this.Controls.Add(this.cbMail);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPhoneMiddle);
            this.Controls.Add(this.tbBirth);
            this.Controls.Add(this.tbPwOk);
            this.Controls.Add(this.tbPw);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SignUp";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.TextBox tbPwOk;
        private System.Windows.Forms.TextBox tbBirth;
        private System.Windows.Forms.TextBox tbPhoneMiddle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.ComboBox cbMail;
        private System.Windows.Forms.TextBox tbPhoneLast;
        private System.Windows.Forms.ComboBox cbPhoneFirst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBSex;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btOverLap;
        private System.Windows.Forms.Label lbOverLap;
        private System.Windows.Forms.Label lbPwStep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbPwOk;
        private System.Windows.Forms.Label lbIdSCCheck;
    }
}