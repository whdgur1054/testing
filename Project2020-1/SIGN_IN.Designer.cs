namespace Project2020_1
{
    partial class SIGN_IN
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.textBox_PW_2 = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.button_accept = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호 확인";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(121, 49);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(150, 21);
            this.textBox_ID.TabIndex = 3;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // textBox_PW
            // 
            this.textBox_PW.Location = new System.Drawing.Point(121, 92);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(150, 21);
            this.textBox_PW.TabIndex = 4;
            this.textBox_PW.UseSystemPasswordChar = true;
            // 
            // textBox_PW_2
            // 
            this.textBox_PW_2.Location = new System.Drawing.Point(121, 139);
            this.textBox_PW_2.Name = "textBox_PW_2";
            this.textBox_PW_2.Size = new System.Drawing.Size(150, 21);
            this.textBox_PW_2.TabIndex = 5;
            this.textBox_PW_2.UseSystemPasswordChar = true;
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(292, 47);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(75, 23);
            this.button_check.TabIndex = 6;
            this.button_check.Text = "중복확인";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // button_accept
            // 
            this.button_accept.Location = new System.Drawing.Point(72, 233);
            this.button_accept.Name = "button_accept";
            this.button_accept.Size = new System.Drawing.Size(75, 23);
            this.button_accept.TabIndex = 7;
            this.button_accept.Text = "가입";
            this.button_accept.UseVisualStyleBackColor = true;
            this.button_accept.Click += new System.EventHandler(this.button_accept_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(226, 233);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "취소";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // SIGN_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 309);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_accept);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.textBox_PW_2);
            this.Controls.Add(this.textBox_PW);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SIGN_IN";
            this.Text = "SIGN_IN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.TextBox textBox_PW_2;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_accept;
        private System.Windows.Forms.Button button_cancel;
    }
}