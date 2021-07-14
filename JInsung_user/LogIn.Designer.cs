
namespace JInsung_user
{
    partial class LogIn
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
            this.lbSignUp = new System.Windows.Forms.Label();
            this.lbSearchId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSearchPw = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.btButton = new System.Windows.Forms.Button();
            this.cbShowPw = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "비밀번호";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignUp.Location = new System.Drawing.Point(12, 96);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(53, 12);
            this.lbSignUp.TabIndex = 1;
            this.lbSignUp.Text = "회원가입";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            // 
            // lbSearchId
            // 
            this.lbSearchId.AutoSize = true;
            this.lbSearchId.Location = new System.Drawing.Point(105, 95);
            this.lbSearchId.Name = "lbSearchId";
            this.lbSearchId.Size = new System.Drawing.Size(69, 12);
            this.lbSearchId.TabIndex = 2;
            this.lbSearchId.Text = "아이디 찾기";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "/";
            // 
            // lbSearchPw
            // 
            this.lbSearchPw.AutoSize = true;
            this.lbSearchPw.Location = new System.Drawing.Point(180, 95);
            this.lbSearchPw.Name = "lbSearchPw";
            this.lbSearchPw.Size = new System.Drawing.Size(81, 12);
            this.lbSearchPw.TabIndex = 4;
            this.lbSearchPw.Text = "비밀번호 찾기";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(76, 12);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 21);
            this.tbId.TabIndex = 5;
            // 
            // tbPw
            // 
            this.tbPw.Location = new System.Drawing.Point(76, 39);
            this.tbPw.Name = "tbPw";
            this.tbPw.PasswordChar = '*';
            this.tbPw.Size = new System.Drawing.Size(100, 21);
            this.tbPw.TabIndex = 6;
            // 
            // btButton
            // 
            this.btButton.Location = new System.Drawing.Point(182, 12);
            this.btButton.Name = "btButton";
            this.btButton.Size = new System.Drawing.Size(82, 48);
            this.btButton.TabIndex = 7;
            this.btButton.Text = "로그인";
            this.btButton.UseVisualStyleBackColor = true;
            this.btButton.Click += new System.EventHandler(this.btButton_Click);
            // 
            // cbShowPw
            // 
            this.cbShowPw.AutoSize = true;
            this.cbShowPw.Location = new System.Drawing.Point(152, 66);
            this.cbShowPw.Name = "cbShowPw";
            this.cbShowPw.Size = new System.Drawing.Size(112, 16);
            this.cbShowPw.TabIndex = 8;
            this.cbShowPw.Text = "비밀번호 보이기";
            this.cbShowPw.UseVisualStyleBackColor = true;
            this.cbShowPw.CheckedChanged += new System.EventHandler(this.cbShowPw_CheckedChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(276, 118);
            this.Controls.Add(this.cbShowPw);
            this.Controls.Add(this.btButton);
            this.Controls.Add(this.tbPw);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbSearchPw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSearchId);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.Label lbSearchId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSearchPw;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.Button btButton;
        private System.Windows.Forms.CheckBox cbShowPw;
    }
}