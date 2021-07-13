
namespace Jinsung_User
{
    partial class logIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.lbSearchId = new System.Windows.Forms.Label();
            this.lbSearchPw = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.btLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignUp.Location = new System.Drawing.Point(12, 105);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(55, 15);
            this.lbSignUp.TabIndex = 2;
            this.lbSignUp.Text = "회원가입";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            // 
            // lbSearchId
            // 
            this.lbSearchId.AutoSize = true;
            this.lbSearchId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSearchId.Location = new System.Drawing.Point(144, 105);
            this.lbSearchId.Name = "lbSearchId";
            this.lbSearchId.Size = new System.Drawing.Size(67, 15);
            this.lbSearchId.TabIndex = 3;
            this.lbSearchId.Text = "아이디찾기";
            this.lbSearchId.Click += new System.EventHandler(this.lbSearchId_Click);
            // 
            // lbSearchPw
            // 
            this.lbSearchPw.AutoSize = true;
            this.lbSearchPw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSearchPw.Location = new System.Drawing.Point(217, 105);
            this.lbSearchPw.Name = "lbSearchPw";
            this.lbSearchPw.Size = new System.Drawing.Size(79, 15);
            this.lbSearchPw.TabIndex = 4;
            this.lbSearchPw.Text = "비밀번호찾기";
            this.lbSearchPw.Click += new System.EventHandler(this.lbSearchPw_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(73, 15);
            this.tbId.Name = "tbId";
            this.tbId.PlaceholderText = "ID";
            this.tbId.Size = new System.Drawing.Size(147, 23);
            this.tbId.TabIndex = 5;
            // 
            // tbPw
            // 
            this.tbPw.Location = new System.Drawing.Point(73, 55);
            this.tbPw.Name = "tbPw";
            this.tbPw.PasswordChar = '*';
            this.tbPw.PlaceholderText = "Password";
            this.tbPw.Size = new System.Drawing.Size(147, 23);
            this.tbPw.TabIndex = 6;
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(226, 15);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(75, 63);
            this.btLogIn.TabIndex = 7;
            this.btLogIn.Text = "로그인";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // cbPw
            // 
            this.cbPw.AutoSize = true;
            this.cbPw.Location = new System.Drawing.Point(73, 83);
            this.cbPw.Name = "cbPw";
            this.cbPw.Size = new System.Drawing.Size(114, 19);
            this.cbPw.TabIndex = 9;
            this.cbPw.Text = "비밀번호 보이기";
            this.cbPw.UseVisualStyleBackColor = true;
            this.cbPw.CheckedChanged += new System.EventHandler(this.cbPw_CheckedChanged);
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 128);
            this.Controls.Add(this.cbPw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.tbPw);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbSearchPw);
            this.Controls.Add(this.lbSearchId);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "logIn";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.Label lbSearchId;
        private System.Windows.Forms.Label lbSearchPw;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPw;
    }
}

